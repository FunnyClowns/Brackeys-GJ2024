using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] CookingTableManager cookingManager;
    PlayerInput playerInput;

    enum MovementState{
        down,
        up,
        right,
        left
    }

    MovementState currentMoveState;

    void Start(){
        playerInput = GetComponent<PlayerInput>();
    }

    void FixedUpdate(){

        CheckAnimation();

        if (playerInput.MoveValue.x == 0 && playerInput.MoveValue.y == 0 && !cookingManager.isCooking){

            switch(currentMoveState){
                case MovementState.down : 
                    animator.Play("PlayerIdle_Down");
                    break;

                case MovementState.up:
                    animator.Play("PlayerIdle_Up");
                    break;

                case MovementState.right:
                    animator.Play("PlayerIdle_Right");
                    break;

                case MovementState.left:
                    animator.Play("PlayerIdle_Left");
                    break;
            }
        }

        if (cookingManager.foodCookedPercentage > 0 && cookingManager.isCooking){
            animator.Play("PlayerCook");
        }
    }

    void CheckAnimation(){

        if (playerInput.MoveValue.y != 0){
            if (playerInput.MoveValue.y > 0){
                animator.Play("PlayerRun_Up");

                currentMoveState = MovementState.up;
            }

            if (playerInput.MoveValue.y < 0){
                animator.Play("PlayerRun_Down");

                currentMoveState = MovementState.down;
            }

        } else
        
        if (playerInput.MoveValue.x != 0){
            if (playerInput.MoveValue.x > 0){
                animator.Play("PlayerRun_Right");

                currentMoveState = MovementState.right;
            }

            if (playerInput.MoveValue.x < 0){
                animator.Play("PlayerRun_Left");

                currentMoveState = MovementState.left;
            }
        }
    }
}

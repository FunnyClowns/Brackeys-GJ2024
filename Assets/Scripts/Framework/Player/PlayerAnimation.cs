using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    [SerializeField] Animator animator;
    PlayerInput playerInput;

    bool isMovingDown;
    bool isMovingUp;
    bool isMovingRight;
    bool isMovingLeft;

    void Start(){
        playerInput = GetComponent<PlayerInput>();
    }

    void FixedUpdate(){

        CheckAnimation();

        if (playerInput.MoveValue.x == 0 && playerInput.MoveValue.y == 0){
            
            if (isMovingDown){
                animator.Play("PlayerIdle_Down");
            }

            if (isMovingUp){
                animator.Play("PlayerIdle_Up");
            }

            if (isMovingRight){
                animator.Play("PlayerIdle_Right");
            }

            if (isMovingLeft){
                animator.Play("PlayerIdle_Left");
            }
        }
    }

    void CheckAnimation(){

        if (playerInput.MoveValue.y != 0){
            if (playerInput.MoveValue.y > 0){
                animator.Play("PlayerRun_Up");

                isMovingUp = true;
                isMovingDown = false;
            }

            if (playerInput.MoveValue.y < 0){
                animator.Play("PlayerRun_Down");

                isMovingDown = true;
                isMovingUp = false;
            }

            isMovingRight = false;
            isMovingLeft = false;

        } else
        
        if (playerInput.MoveValue.x != 0){
            if (playerInput.MoveValue.x > 0){
                animator.Play("PlayerRun_Right");

                isMovingRight = true;
                isMovingLeft = false;
            }

            if (playerInput.MoveValue.x < 0){
                animator.Play("PlayerRun_Left");

                isMovingLeft = true;
                isMovingRight = false;
            }

            isMovingDown = false;
            isMovingUp = false;

        }
    }
}

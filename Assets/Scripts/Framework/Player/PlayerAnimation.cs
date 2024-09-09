using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    [SerializeField] Animator animator;
    PlayerInput playerInput;
    PlayerMovement playerMovement;

    void Start(){
        playerInput = GetComponent<PlayerInput>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    void FixedUpdate(){

        if (playerInput.MoveValue.y != 0){
            if (playerInput.MoveValue.y > 0){
                animator.Play("PlayerRun_Up");
            }

            if (playerInput.MoveValue.y < 0){
                animator.Play("PlayerRun_Down");
            }
        } else
        
        if (playerInput.MoveValue.x != 0){
            if (playerInput.MoveValue.x > 0){
                animator.Play("PlayerRun_Right");
            }

            if (playerInput.MoveValue.x < 0){
                animator.Play("PlayerRun_Left");
            }

        }

        if (playerInput.MoveValue.x == 0 && playerInput.MoveValue.y == 0){
            animator.Play("Player_Idle");
        }
    }
}

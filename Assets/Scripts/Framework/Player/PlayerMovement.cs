using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    PlayerInput playerInput;
    Rigidbody2D rb;

    [SerializeField, Range(1f, 10f)] float moveSpeed = 5f;
    [HideInInspector] public bool isMoving;

    void Start(){
        playerInput = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate(){
        rb.velocity = playerInput.MoveValue * moveSpeed;

        if (playerInput.MoveValue.x != 0 || playerInput.MoveValue.y != 0){
            isMoving = true;
        } else {
            isMoving = false;
        }
    }

}

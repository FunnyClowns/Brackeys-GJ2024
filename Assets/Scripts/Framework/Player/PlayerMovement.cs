using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    PlayerInput playerInput;
    Rigidbody2D rb;

    [SerializeField, Range(1f, 10f)] float moveSpeed = 5f;

    void Start(){
        playerInput = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate(){
        rb.velocity = playerInput.MoveValue * moveSpeed;
    }

}

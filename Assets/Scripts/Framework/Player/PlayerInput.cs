using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour{
    PlayerController playerController;

    [HideInInspector] public Vector2 MoveValue;

    void Start(){
        playerController = GetComponent<PlayerController>();
    }

    public void OnMovementInput(InputAction.CallbackContext context){
        MoveValue = context.ReadValue<Vector2>();
    }
}
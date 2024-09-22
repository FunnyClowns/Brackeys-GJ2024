using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour{
    PlayerCollision playerCollision;

    [HideInInspector] public Vector2 MoveValue;

    void Start(){
        playerCollision = GetComponent<PlayerCollision>();
    }

    public void OnMovementInput(InputAction.CallbackContext context){
        MoveValue = context.ReadValue<Vector2>();
    }

    public void OnInteractInput(InputAction.CallbackContext context){
        if (playerCollision.onCollidingObject != null && playerCollision.onCollidingObject.TryGetComponent<IClickable>(out IClickable clickable)){
            clickable.Interact();
        }
    }
}
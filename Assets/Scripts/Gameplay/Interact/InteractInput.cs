using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class InteractInput : MonoBehaviour
{
    InteractManager interactManager;

    [SerializeField] UnityEvent cookingTrigger;
    [SerializeField] UnityEvent converterTrigger;
    [SerializeField] UnityEvent fridgeTrigger;

    void Start(){
        interactManager = GetComponent<InteractManager>();
    }
    public void OnInteractInput(InputAction.CallbackContext context){
        
        switch(interactManager.currentState){
            case InteractManager.interactState.cooking:
                cookingTrigger.Invoke();
                break;

            case InteractManager.interactState.converter:
                converterTrigger.Invoke();
                break;

            case InteractManager.interactState.fridge:
                fridgeTrigger.Invoke();
                break;
        }
    }

}

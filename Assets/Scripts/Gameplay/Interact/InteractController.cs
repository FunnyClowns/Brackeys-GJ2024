using UnityEngine;

public class InteractManager : MonoBehaviour
{
    public enum interactState{
        cooking,
        converter,
        fridge
    }

    [HideInInspector] public interactState currentState;

    public void ChangeState(interactState state){

        currentState = state;
    }

}

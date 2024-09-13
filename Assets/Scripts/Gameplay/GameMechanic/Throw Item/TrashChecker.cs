using UnityEngine;

public class TrashChecker : MonoBehaviour, IClickable{

    [SerializeField] TrashManager trashManager;
    [SerializeField] PlayerController playerController;

    bool canTrigger(){
        return playerController.isCarryFood || playerController.isCarryMeat;
    }

    public void Interact(){
        if (canTrigger()){
            trashManager.TriggerThrowItem();

            Debug.Log("Test");
        }

    }   
}
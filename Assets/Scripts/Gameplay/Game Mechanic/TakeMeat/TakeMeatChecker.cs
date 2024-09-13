using UnityEngine;

public class TakeMeatChecker : MonoBehaviour, IClickable{

    [SerializeField] FridgeManager fridgeManager;
    [SerializeField] PlayerController playerController;

    bool canTrigger(){

        return !playerController.isCarryFood && !playerController.isCarryMeat && fridgeManager.meatAmount > 0;
    }
    public void Interact(){
        
        if (canTrigger()){
            fridgeManager.TriggerTakeMeat();
        }
    }
}
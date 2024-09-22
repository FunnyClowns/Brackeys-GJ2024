using UnityEngine;

public class TableCollision : MonoBehaviour,IClickable
{
    [SerializeField] PlayerController playerController;
    [SerializeField] TableManager TableManager;

    bool canPlaceFood(){

        return playerController.isCarryFood && !TableManager.isTableFull;
    }

    bool canTakeFood(){
        return !playerController.isCarryFood && !playerController.isCarryMeat && TableManager.isTableFull;
    }

    public void Interact(){
        if (canPlaceFood()){
            TableManager.OnTriggerPlaceFood();

            return;
        }

        if (canTakeFood()){
            TableManager.OnTriggerTakeFood();

            return;
        }

    }

    public void OnNearby(){
    }

    public void OnFar(){
    }
}

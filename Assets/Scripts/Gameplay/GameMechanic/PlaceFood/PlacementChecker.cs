using UnityEngine;

public class PlacementChecker : MonoBehaviour,IClickable
{
    [SerializeField] PlayerController playerController;
    [SerializeField] PlacementManager placementManager;

    bool canPlaceFood(){

        return playerController.isCarryFood && !placementManager.isTableFull;
    }

    bool canTakeFood(){
        return !playerController.isCarryFood && placementManager.isTableFull;
    }

    public void Interact(){
        if (canPlaceFood()){
            placementManager.OnTriggerPlaceFood();

            return;
        }

        if (canTakeFood()){
            placementManager.OnTriggerTakeFood();

            return;
        }

    }

    public void OnNearby(){
    }

    public void OnFar(){
    }
}

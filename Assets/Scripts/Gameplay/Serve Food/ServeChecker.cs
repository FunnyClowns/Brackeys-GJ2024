using UnityEngine;

public class SaveChecker : MonoBehaviour, IClickable
{  

    [SerializeField] PlayerController playerController;
    [SerializeField] ServeManager serveManager;

    bool canTriggerServe(){
        return playerController.isCarryFood;
    }

    public void Interact(){
        if (canTriggerServe()){
            serveManager.TriggerServe();
            playerController.PlaceFood();
        } else {
            Debug.Log("No carry food");
        }
    }
}

using UnityEngine;

public class ServeChecker : MonoBehaviour, IClickable
{  

    [SerializeField] PlayerController playerController;
    [SerializeField] ServeManager serveManager;

    bool canTriggerServe(){
        return playerController.isCarryFood;
    }

    public void Interact(){
        if (canTriggerServe()){
            serveManager.TriggerServe();
        } else {
            Debug.Log("No carry food");
        }
    }
}

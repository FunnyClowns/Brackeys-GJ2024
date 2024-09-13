using UnityEngine;

public class ServeChecker : MonoBehaviour, IClickable
{  

    [SerializeField] PlayerController playerController;
    [SerializeField] CookingManager cookingManager;
    [SerializeField] ServeManager serveManager;

    bool canTriggerServe(){
        return playerController.isCarryFood && cookingManager.mealsCount > 0;
    }

    public void Interact(){
        if (canTriggerServe()){
            serveManager.TriggerServe();
        } else {
            Debug.Log("Cant serve yet");
        }
    }
}

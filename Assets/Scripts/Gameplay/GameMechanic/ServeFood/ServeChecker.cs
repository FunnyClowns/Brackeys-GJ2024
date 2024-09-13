using UnityEngine;

public class ServeChecker : MonoBehaviour, IClickable
{  

    [SerializeField] PlayerController playerController;
    [SerializeField] CookingManager cookingManager;
    [SerializeField] ServeManager serveManager;

    [SerializeField] SpriteRenderer SR_Converter;
    [SerializeField] Sprite mainSprite;
    [SerializeField] Sprite nearbySprite;

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

    public void OnNearby(){
        SR_Converter.sprite = nearbySprite;
    }

    public void OnFar(){
        SR_Converter.sprite = mainSprite;
    }
}

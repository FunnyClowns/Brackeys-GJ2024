using UnityEngine;

public class ServeCollision : MonoBehaviour, IClickable
{  

    [SerializeField] PlayerController playerController;
    [SerializeField] CookingTableManager cookingManager;
    [SerializeField] ServeManager serveManager;

    [SerializeField] SpriteRenderer SR_Converter;
    [SerializeField] Sprite mainSprite;
    [SerializeField] Sprite nearbySprite;

    bool canTriggerServe(){
        return playerController.isCarryFood && cookingManager.mealsOrderCount > 0;
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

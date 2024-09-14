using UnityEngine;

public class FridgeCollision : MonoBehaviour, IClickable{

    [SerializeField] FridgeManager fridgeManager;
    [SerializeField] PlayerController playerController;

    [SerializeField] GameObject UI_Ingredients;

    [SerializeField] SpriteRenderer SR_Fridge;
    [SerializeField] Sprite mainSprite;
    [SerializeField] Sprite nearbySprite;

    bool canTrigger(){

        return !playerController.isCarryFood && !playerController.isCarryMeat && fridgeManager.meatAmount > 0;
    }
    public void Interact(){
        
        if (canTrigger()){
            fridgeManager.TriggerTakeMeat();
        }
    }

    public void OnNearby(){
        SR_Fridge.sprite = nearbySprite;

        UI_Ingredients.SetActive(true);
    }

    public void OnFar(){
        SR_Fridge.sprite = mainSprite;
        
        UI_Ingredients.SetActive(false);
    }
}
using UnityEngine;

public class CookChecker : MonoBehaviour, IClickable{

    [SerializeField] CookingManager cookingManager;
    [SerializeField] PlayerController playerController;

    [SerializeField] SpriteRenderer SR_Oven;
    [SerializeField] Sprite mainSprite;
    [SerializeField] Sprite nearbySprite;

    [SerializeField,Range(0.1f, 0.5f)] float cooldownTime;
    float timeUntilNextTrigger;


    void Update(){
        // TIMER

        if (timeUntilNextTrigger > 0){
            timeUntilNextTrigger -= Time.deltaTime;
        }

    }

    bool canTriggerCook(){
        
        return timeUntilNextTrigger <= 0 && !playerController.isCarryFood && playerController.isCarryMeat;
    }

    public void Interact(){

        if (canTriggerCook()){
            timeUntilNextTrigger = cooldownTime;
            cookingManager.TriggerCook();
        }
    }

    public void OnNearby(){
        SR_Oven.sprite = nearbySprite;
    }

    public void OnFar(){
        SR_Oven.sprite = mainSprite;
    }


}
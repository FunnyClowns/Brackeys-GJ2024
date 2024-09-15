using UnityEngine;

public class CookingTableCollision : MonoBehaviour, IClickable{

    [SerializeField] CookingTableManager CookingTableManager;
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
            CookingTableManager.TriggerCook();
        }
    }

    public void OnNearby(){
        SR_Oven.sprite = nearbySprite;
    }

    public void OnFar(){
        SR_Oven.sprite = mainSprite;
    }


}
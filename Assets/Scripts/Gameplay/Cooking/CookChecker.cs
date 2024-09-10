using UnityEngine;

public class CookChecker : MonoBehaviour, IClickable{

    [SerializeField] CookingManager cookingManager;

    [SerializeField,Range(0.1f, 0.5f)] float cooldownTime;
    float timeUntilNextTrigger;

    bool isPlayerNearby;

    void Update(){
        // TIMER

        if (timeUntilNextTrigger > 0){
            timeUntilNextTrigger -= Time.deltaTime;
        }

    }

    bool canTriggerCook(){
        
        return timeUntilNextTrigger <= 0;
    }

    public void PlayerNearby(){
        isPlayerNearby = true;
        Debug.Log("Nearby");
    }

    public void PlayerOpposite(){
        isPlayerNearby = false;
    }

    public void Interact(){

        if (canTriggerCook()){
            timeUntilNextTrigger = cooldownTime;
            cookingManager.TriggerCook();
        }
    }


}
using UnityEngine;
using UnityEngine.InputSystem;

public class CookGameplayInput : MonoBehaviour{

    CookingData cookingData;

    [SerializeField,Range(0.1f, 0.5f)] float cooldownTime;
    float timeUntilNextTrigger;

    bool isPlayerNearby;

    void Start(){
        cookingData = GetComponent<CookingData>();
    }

    void Update(){
        // TIMER

        if (timeUntilNextTrigger > 0){
            timeUntilNextTrigger -= Time.deltaTime;
        }

    }

    bool canTriggerCook(){
        
        return isPlayerNearby && timeUntilNextTrigger <= 0;
    }

    public void PlayerNearby(){
        isPlayerNearby = true;
        Debug.Log("Nearby");
    }

    public void PlayerOpposite(){
        isPlayerNearby = false;
    }

    public void OnCookInput(InputAction.CallbackContext context){
        if (canTriggerCook()){
            timeUntilNextTrigger = cooldownTime;
            cookingData.TriggerCook();
        }
    }


}
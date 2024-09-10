using UnityEngine;

public class CookingData : MonoBehaviour{

    int foodCookedPercentage;

    bool isCooked;

    public void TriggerCook(){

        if (foodCookedPercentage >= 10){
            
            if (!isCooked){
                Debug.Log("COOKED");
                isCooked = true;
            }
            
            return;
        }
        
        foodCookedPercentage += 1;

        Debug.Log("Cook");
    }
}
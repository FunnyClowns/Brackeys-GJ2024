using System.Collections;
using UnityEngine;

public class CookingManager : MonoBehaviour, ISliderValue{

    [SerializeField] PlayerController playerController;

    int customerCount;

    int foodCookedPercentage;
    bool isCooked;

    void Start(){

        StartCoroutine(SpawnCustomerCoroutine());
    }

    IEnumerator SpawnCustomerCoroutine(){
        
        float randomSpawnTime = Random.Range(20f, 50f);

        yield return new WaitForSeconds(randomSpawnTime);

        NewFoodOrder();

        Debug.Log("Food Orders Count : " + customerCount);
    }

    void NewFoodOrder(){
        customerCount += 1;
    }

    public void TriggerCook(){

        if (foodCookedPercentage >= 10){
            
            if (!isCooked){
                Debug.Log("COOKED");
                isCooked = true;
                foodCookedPercentage = 0;

                playerController.TakeFood();
            }
            
            return;
        }
        
        foodCookedPercentage += 1;
        isCooked = false;

        Debug.Log("Cook");
    }
    
    public float SliderValue(){
        return foodCookedPercentage;
    }
}
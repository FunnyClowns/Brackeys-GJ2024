using System.Collections;
using TMPro;
using UnityEngine;

public class CookingManager : MonoBehaviour, ISliderValue{

    [SerializeField] PlayerController playerController;
    [SerializeField] TextMeshProUGUI mealsCountText;

    [HideInInspector] public int mealsCount;

    int foodCookedPercentage;
    bool isCooked;

    void Start(){

        StartCoroutine(SpawnCustomerCoroutine());

        mealsCountText.text = mealsCount.ToString();
    }

    IEnumerator SpawnCustomerCoroutine(){
        
        float randomSpawnTime = Random.Range(10f, 30f);

        yield return new WaitForSeconds(randomSpawnTime);

        NewMealsOrder();

        Debug.Log("Food Orders Count : " + mealsCount);
    }

    void NewMealsOrder(){
        mealsCount += 1;
        mealsCountText.text = mealsCount.ToString();
    }

    public void DecreaseMealsOrder(){
        mealsCount -= 1;
        mealsCountText.text = mealsCount.ToString();
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
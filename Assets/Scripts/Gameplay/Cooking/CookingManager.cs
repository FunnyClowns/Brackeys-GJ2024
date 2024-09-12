using System.Collections;
using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CookingManager : MonoBehaviour, ISliderValue{

    [SerializeField] PlayerController playerController;
    [SerializeField] TextMeshProUGUI mealsCountText;
    [SerializeField] UnityEngine.UI.Image clienstArrivedImage;

    [HideInInspector] public int mealsCount;

    int foodCookedPercentage;
    bool isCooked;

    void Start(){

        StartCoroutine(SpawnCustomerCoroutine());

        mealsCountText.text = mealsCount.ToString();
    }

    IEnumerator SpawnCustomerCoroutine(){
        
        float randomSpawnTime = Random.Range(5f, 10f);

        yield return new WaitForSeconds(randomSpawnTime);

        NewMealsOrder();

        Debug.Log("Food Orders Count : " + mealsCount);
    }

    void NewMealsOrder(){
        mealsCount += 1;
        mealsCountText.text = mealsCount.ToString();

        StartCoroutine(ShowClientsArrived());
    }

    public void DecreaseMealsOrder(){
        mealsCount -= 1;
        mealsCountText.text = mealsCount.ToString();
    }

    IEnumerator ShowClientsArrived(){

        clienstArrivedImage.enabled = true;

        yield return new WaitForSeconds(1.5f);

        clienstArrivedImage.enabled = false;
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
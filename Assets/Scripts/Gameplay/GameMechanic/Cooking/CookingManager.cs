using System.Collections;
using TMPro;
using UnityEngine;

public class CookingManager : MonoBehaviour, ISliderValue{

    [SerializeField] PlayerController playerController;
    [SerializeField] PlayerInput playerInput;
    [SerializeField] TextMeshProUGUI mealsCountText;
    [SerializeField] UnityEngine.UI.Image clienstArrivedImage;

    [HideInInspector] public int mealsCount;

    [HideInInspector] public int foodCookedPercentage;
    [HideInInspector] public bool isCooking;
    bool isCooked;

    void Start(){

        StartCoroutine(SpawnCustomerCoroutine());

        mealsCountText.text = mealsCount.ToString();
    }

    void Update(){
        if ((playerInput.MoveValue.x != 0 || playerInput.MoveValue.y != 0)){
            foodCookedPercentage = 0;
            isCooking = false;
        }
    }   

    IEnumerator SpawnCustomerCoroutine(){
        
        float randomSpawnTime = Random.Range(20f, 30f);

        Debug.Log("Random Time : " + randomSpawnTime);

        yield return new WaitForSeconds(randomSpawnTime);

        NewMealsOrder();

        Debug.Log("Food Orders Count : " + mealsCount);
    }

    void NewMealsOrder(){
        mealsCount += 1;
        mealsCountText.text = mealsCount.ToString();

        StartCoroutine(ShowClientsArrived());
        StartCoroutine(SpawnCustomerCoroutine());
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
                isCooking = false;
                foodCookedPercentage = 0;

                playerController.TakeFood(null);
                playerController.isCarryMeat = false;
            }
            
            return;
        }
        
        foodCookedPercentage += 1;
        isCooked = false;
        isCooking = true;

        playerController.playerItem.enabled = false;

        Debug.Log("Cook");
    }
    
    public float SliderValue(){
        return foodCookedPercentage;
    }
}
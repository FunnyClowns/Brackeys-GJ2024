using System.Collections;
using TMPro;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UI;

public class CookingTableManager : MonoBehaviour, ISliderValue{

    [SerializeField] PlayerController playerController;
    [SerializeField] PlayerInput playerInput;
    [SerializeField] TextMeshProUGUI mealsOrderText;
    [SerializeField] UnityEngine.UI.Image clienstArrivedImage;
    [SerializeField] Image cookingBarHolder;

    [SerializeField] ClientsController clientsController;

    [HideInInspector] public int mealsOrderCount;

    [HideInInspector] public int foodCookedPercentage;
    [HideInInspector] public bool isCooking;
    bool isCooked;

    void Start(){

        StartCoroutine(SpawnCustomerCoroutine());

        mealsOrderText.text = mealsOrderCount.ToString();
    }

    void Update(){
        if ((playerInput.MoveValue.x != 0 || playerInput.MoveValue.y != 0) && isCooking){
            foodCookedPercentage = 0;
            isCooking = false;

            playerController.playerItem.enabled = true;
        }

        if (foodCookedPercentage == 0){
            cookingBarHolder.enabled = false;
        }
    }   

    IEnumerator SpawnCustomerCoroutine(){
        
        float randomSpawnTime = Random.Range(20f, 30f);

        Debug.Log("Random Time : " + randomSpawnTime);

        yield return new WaitForSeconds(randomSpawnTime);

        NewMealsOrder();
        clientsController.StartTimer();

        Debug.Log("Food Orders Count : " + mealsOrderCount);
    }

    void NewMealsOrder(){
        mealsOrderCount += 1;
        mealsOrderText.text = mealsOrderCount.ToString();

        StartCoroutine(ShowClientsArrived());
        StartCoroutine(SpawnCustomerCoroutine());
    }

    public void DecreaseMealsOrder(){
        mealsOrderCount -= 1;
        mealsOrderText.text = mealsOrderCount.ToString();
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

        cookingBarHolder.enabled = true;

        Debug.Log("Cook");
    }
    
    public float SliderValue(){
        return foodCookedPercentage;
    }
}
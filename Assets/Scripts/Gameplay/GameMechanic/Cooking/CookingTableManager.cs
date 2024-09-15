using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CookingTableManager : MonoBehaviour, ISliderValue{

    [SerializeField] GameManager gameManager;
    [SerializeField] PlayerController playerController;
    [SerializeField] PlayerInput playerInput;
    [SerializeField] TextMeshProUGUI mealsOrderText;
    [SerializeField] UnityEngine.UI.Image clienstArrivedImage;
    [SerializeField] Image cookingBarHolder;
    [SerializeField] Image cookingFace;
    [SerializeField] List<Sprite> faces = new List<Sprite>();

    [SerializeField] AudioSource cookAudio;
    [SerializeField] AudioSource alarmAudio;

    [SerializeField] ClientsController clientsController;

    [HideInInspector] public int mealsOrderCount;

    [HideInInspector] public int foodCookedPercentage;
    [HideInInspector] public bool isCooking;
    bool isCooked;

    Vector2 clientSpawnTime;

    void Start(){

        StartCoroutine(SpawnCustomerCoroutine());

        mealsOrderText.text = mealsOrderCount.ToString();
        OnCalmHour();
    }

    void Update(){
        if ((playerInput.MoveValue.x != 0 || playerInput.MoveValue.y != 0) && isCooking){
            foodCookedPercentage = 0;
            isCooking = false;
            
            cookAudio.Stop();
            cookingFace.enabled = false;
            playerController.playerItem.enabled = true;
        }

        if (foodCookedPercentage == 0){
            cookingBarHolder.enabled = false;
        }
    }   

    IEnumerator SpawnCustomerCoroutine(){
        
        float randomSpawnTime = Random.Range(clientSpawnTime.x, clientSpawnTime.y);

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

        alarmAudio.Play();
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

        if (foodCookedPercentage >= 6){
            
            if (!isCooked){
                Debug.Log("COOKED");
                isCooked = true;
                isCooking = false;
                foodCookedPercentage = 0;

                playerController.TakeFood(null);
                playerController.isCarryMeat = false;
                cookingFace.enabled = false;

                cookAudio.Stop();
            }
            
            return;
        }
        
        ChangeFaces();

        foodCookedPercentage += 1;
        isCooked = false;
        isCooking = true;

        playerController.playerItem.enabled = false;

        cookingBarHolder.enabled = true;
        cookingFace.enabled = true;

        if (!cookAudio.isPlaying){
            cookAudio.Play();

        }

        Debug.Log("Cook");
    }

    void ChangeFaces(){

        if (faces.Count > foodCookedPercentage){
            cookingFace.sprite = faces[foodCookedPercentage];
        }
    }

    public void OnCalmHour(){
        clientSpawnTime = gameManager.Time_ClientSpawn;
    }

    public void OnRushHour(){
        clientSpawnTime = gameManager.TimeRush_ClientSpawn;
    }
    
    public float SliderValue(){
        return foodCookedPercentage;
    }
}
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClientsController : MonoBehaviour, ISliderValue
{
    
    [SerializeField] GameManager gameManager;
    [SerializeField] CookingTableManager cookingTable;
    [SerializeField] Image facesImage;
    [SerializeField] List<Sprite> dragonFaces = new List<Sprite>();

    float clientsRageTime;
    float clientsRageTimeCounter;

    int clientsRagePercentage = 0;

    bool isTimerStarted;

    void Start(){
        clientsRageTime = gameManager.Time_ClientRage;
    }


    void Update(){

        // TIMER
        if (isTimerStarted){
            clientsRageTimeCounter -= Time.deltaTime;
        }

        if (clientsRageTimeCounter <= 0 && isTimerStarted){
            AddClientsRage();
            ResetTimer();
        }
        
    }

    public void StartTimer(){

        Debug.Log("Timer started : " + isTimerStarted);

        if (!isTimerStarted){
            clientsRageTimeCounter = clientsRageTime;
            isTimerStarted = true;

            Debug.Log("Start Rage Timer");
        }

    }

    public void ResetTimer(){
        
        if (isTimerStarted && cookingTable.mealsOrderCount > 0){
            isTimerStarted = true;
            clientsRageTimeCounter = clientsRageTime;

            Debug.Log("Reset Rage Timer to normal");
        }

        if (isTimerStarted && cookingTable.mealsOrderCount <= 0){
            isTimerStarted = false;
            clientsRageTimeCounter = 0;

            Debug.Log("Reset Rage Timer to zero");
        }

    }

    void AddClientsRage(){
        clientsRagePercentage += 1;

        if (clientsRagePercentage >= 6){
            GameOver();
        }

        if (!gameManager.isGameOver){
            facesImage.sprite = dragonFaces[clientsRagePercentage];
        }

        Debug.Log ("Clients Rage : " + clientsRagePercentage);
    }

    void GameOver(){
        gameManager.GameOver();
    }

    public float SliderValue(){
        return clientsRagePercentage;
    }

}

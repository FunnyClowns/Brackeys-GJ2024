using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
   [SerializeField] public Vector2 Time_ClientSpawn;
   [SerializeField] public Vector2 TimeRush_ClientSpawn;
   [SerializeField] public float Time_ClientRage;
   [SerializeField] public Vector2 Time_RushHourCountdown;
   [SerializeField] public Vector2 Time_RushHour;
   [SerializeField] public int ClientsToFeed;

   [SerializeField] CookingTableManager cookingTable;

    [SerializeField] UnityEngine.UI.Image gameOverHolder;
   [SerializeField] List<Sprite> gameOverImages = new List<Sprite>();
   [SerializeField] Sprite gameWin;
   [HideInInspector] public bool isGameOver = false;


    public void StartRushHour(){
        cookingTable.OnRushHour();

        Debug.Log("RUSH HOURRR");
    }

    public void StartCalmHour(){
        cookingTable.OnCalmHour();

        Debug.Log("CALMM HOURRR");
    }

    public void GameWin(){

        if (!isGameOver){
            isGameOver = true;

            gameOverHolder.enabled = true;
            gameOverHolder.sprite = gameWin;
        }
    }

    public void GameOver(){
        
        if (!isGameOver){
            isGameOver = true;

            int randomNum = Random.Range(0, gameOverImages.Count);

            gameOverHolder.enabled = true;
            gameOverHolder.sprite = gameOverImages[randomNum];
        }
    }

}

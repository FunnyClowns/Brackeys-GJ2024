using UnityEngine;

public class GameManager : MonoBehaviour
{
   [SerializeField] public Vector2 Time_ClientSpawn;
   [SerializeField] public Vector2 TimeRush_ClientSpawn;
   [SerializeField] public float Time_ClientRage;
   [SerializeField] public Vector2 Time_RushHourCountdown;
   [SerializeField] public Vector2 Time_RushHour;

   [SerializeField] CookingTableManager cookingTable;


    public void StartRushHour(){
        cookingTable.OnRushHour();

        Debug.Log("RUSH HOURRR");
    }

    public void StartCalmHour(){
        cookingTable.OnCalmHour();

        Debug.Log("CALMM HOURRR");
    }

}

using System.Collections;
using UnityEngine;
using UnityEngine.Playables;

public class RushHourController : MonoBehaviour
{
    
    [SerializeField] GameManager gameManager;
    [SerializeField] PlayableDirector clientsTransition;

    Vector2 RushHourTime;
    Vector2 RushHourTimeCountdown;


    void Start(){
        RushHourTime = gameManager.Time_RushHour;
        RushHourTimeCountdown = gameManager.Time_RushHourCountdown;

        StartCoroutine(RushHourCountdown());
    }

    IEnumerator RushHourCountdown(){
        
        float randomCountdownTime = Random.Range(RushHourTimeCountdown.x, RushHourTimeCountdown.y);
        float randomTime = Random.Range(RushHourTime.x, RushHourTime.y);

        gameManager.StartCalmHour();

        yield return new WaitForSeconds(randomCountdownTime);

        clientsTransition.Play();

        yield return new WaitForSeconds(7f);

        gameManager.StartRushHour();

        yield return new WaitForSeconds(randomTime);

        StartCoroutine(RushHourCountdown());
    }

    void MoveMonster(){

    }
}

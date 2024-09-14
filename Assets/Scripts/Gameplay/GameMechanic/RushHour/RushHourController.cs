using System.Collections;
using UnityEngine;
using UnityEngine.Playables;

public class RushHourController : MonoBehaviour
{
    
    [SerializeField] GameManager gameManager;
    [SerializeField] PlayableDirector clientsRushTransition;
    [SerializeField] PlayableDirector clientsCalmTransition;

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

        clientsRushTransition.Play();

        yield return new WaitForSeconds(7f);

        clientsRushTransition.Stop();
        gameManager.StartRushHour();

        yield return new WaitForSeconds(randomTime);

        clientsCalmTransition.Play();

        yield return new WaitForSeconds(7f);

        clientsCalmTransition.Stop();

        StartCoroutine(RushHourCountdown());
    }
}

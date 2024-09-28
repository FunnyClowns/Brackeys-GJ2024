using System.Collections;
using UnityEngine;

public class FightingController : MonoBehaviour
{

    [HideInInspector]
    public EnemyData selectedEnemy;

    [SerializeField]
    PlayerFightingData player;

    [SerializeField]
    EnemyData Enemy1;

    [SerializeField]
    EnemyData Enemy2;

    [SerializeField]
    EnemyData Enemy3;

    bool isPlayerTurn = true;

    void Start(){
        selectedEnemy = Enemy1;
    }

    public void AttackEnemy(){
        
        if (isPlayerTurn){
            selectedEnemy.ChangeHealth(-5);
            isPlayerTurn = false;
            
            StartCoroutine(GameLoopTurn());

            Debug.Log("Enemy Health : " + selectedEnemy.currentHealth);
        }
        
    }

    public IEnumerator GameLoopTurn(){

        Enemy1.AttackPlayer();

        player.StartCoroutine(player.Hurt());

        yield return new WaitForSeconds(2f);

        Enemy1.Idle();
        Enemy2.AttackPlayer();

        player.StartCoroutine(player.Hurt());

        yield return new WaitForSeconds(2f);

        Enemy2.Idle();
        Enemy3.AttackPlayer();

        player.StartCoroutine(player.Hurt());

        yield return new WaitForSeconds(2f);

        Enemy3.Idle();

        isPlayerTurn = true;
    }



    
}

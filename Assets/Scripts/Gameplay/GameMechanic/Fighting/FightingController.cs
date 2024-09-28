using System.Collections;
using UnityEngine;

public class FightingController : MonoBehaviour
{

    [HideInInspector]
    public EnemyData selectedEnemy;

    [SerializeField]
    PlayerData player;

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

        yield return new WaitForSeconds(2f);

        Enemy1.Idle();
        Enemy2.AttackPlayer();

        yield return new WaitForSeconds(2f);

        Enemy2.Idle();
        Enemy3.AttackPlayer();

        yield return new WaitForSeconds(2f);

        Enemy3.Idle();
        isPlayerTurn = true;
    }



    
}

using UnityEngine;

public class FightingController : MonoBehaviour
{

    [HideInInspector]
    public EnemyData selectedEnemy;

    public void AttackEnemy(){
        selectedEnemy.currentHealth -= 5;

        Debug.Log("Enemy Health : " + selectedEnemy.currentHealth);
    }
}

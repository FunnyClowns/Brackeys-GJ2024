using UnityEngine;

public class SelectingEnemiesHandler : MonoBehaviour
{
    
    [SerializeField] FightingController fightingController;
    [SerializeField] EnemyData currentEnemy;


    public void OnClickEnemy(){
        ChangeCurrentSelectedEnemy();
    }

    void ChangeCurrentSelectedEnemy(){
        fightingController.selectedEnemy = currentEnemy;

        Debug.Log(fightingController.selectedEnemy);
    }
}

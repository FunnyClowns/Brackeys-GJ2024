using UnityEngine;

public class EnemyData : MonoBehaviour
{   

    [SerializeField]
    PlayerFightingData player;
    Animator animator;

    [HideInInspector]
    public int currentHealth;

    [SerializeField]
    int maxHealth;

    void Awake(){
        currentHealth = maxHealth;
        animator = GetComponent<Animator>();
    }

    public void ChangeHealth(int amount){
        currentHealth += amount;
    }

    public void AttackPlayer(){
        player.ChangeHealth(-5);

        animator.Play("Attack");

        Debug.Log("Attacked Player");
    }

    public void Idle(){
        animator.Play("Idle");
    }
}

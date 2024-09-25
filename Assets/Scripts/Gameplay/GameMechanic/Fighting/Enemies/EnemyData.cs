using UnityEngine;

public class EnemyData : MonoBehaviour
{   
    [HideInInspector]
    public int currentHealth;

    [SerializeField]
    int maxHealth;

    void Awake(){
        currentHealth = maxHealth;
    }
}

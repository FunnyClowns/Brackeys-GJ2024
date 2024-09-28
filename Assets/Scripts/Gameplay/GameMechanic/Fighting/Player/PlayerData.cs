using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [HideInInspector]
    int currentHealth;

    [SerializeField]
    int maxHealth;

    void Awake(){
        currentHealth = maxHealth;
    }

    public void ChangeHealth(int amount){
        currentHealth += amount;
    }

}

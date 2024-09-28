using System.Collections;
using UnityEngine;

public class PlayerFightingData : MonoBehaviour
{
    [HideInInspector]
    int currentHealth;

    [SerializeField]
    int maxHealth;

    UnityEngine.UI.Image playerImage;

    [SerializeField]
    Sprite playerIdle;

    [SerializeField]
    Sprite playerAttacked;

    void Awake(){
        currentHealth = maxHealth;
        playerImage = GetComponent<UnityEngine.UI.Image>();

        playerImage.sprite = playerIdle;
    }

    public void ChangeHealth(int amount){
        currentHealth += amount;
    }

    public IEnumerator Hurt(){
        
        yield return new WaitForSeconds(0.8f);

        playerImage.sprite = playerAttacked;

        yield return new WaitForSeconds(1f);

        playerImage.sprite = playerIdle;
    }

}

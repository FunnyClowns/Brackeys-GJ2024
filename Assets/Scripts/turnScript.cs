using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnScript : MonoBehaviour
{

    public GameObject player;

    public int maxDamage = 3;

    public int minDamage = 1;

    public int minHealth = 1;

    public int maxHealth = 3;

    public int minBlock = 1;

    public int maxblock = 3;
    /*
    void Start()
    {
        player.GetComponent<healthScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void damage()
    {
        int damage = Random.Range(minDamage, maxDamage + 1);
        if (healthScript.isTurn)
        {
            healthScript.isTurn = false;
            //healthScript.healthScript.takeDamage(damage);
        }
        
    }

    void heal()
    {
        int heal = Random.Range(minHealth, maxHealth + 1);
        if (healthScript.isTurn)
        {
            healthScript.isTurn = false;
            healthScript..Heal(heal);
        }
    }

*/
}

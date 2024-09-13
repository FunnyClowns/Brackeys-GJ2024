using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIturnScript : MonoBehaviour
{
    public healthScript healthScript; 

    public Text uiElement;

    public int type = 0;

    //1 = attack
    //2 = heal
    //3 = block
    //4 = multiplier
    
    public int minDamage = 1;

    public int maxDamage = 3;

    public int minHealth = 1;

    public int maxHealth = 3;

    public int minBlock = 1;

    public int maxblock = 3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (type == 1)
        {
            uiElement.text = "Attack: " + healthScript.damage.ToString();
        }
        if (type == 2)
        {
            uiElement.text = "Heal: " + healthScript.heal.ToString();
        }
        if (type == 3)
        {
            uiElement.text = "Block: " + healthScript.block.ToString();
        }
        if (type == 4)
        {
            uiElement.text = "Multiplier: " + healthScript.multiplier.ToString();
        }
    }

    public void attack()
    {
        if (healthScript.isTurn)
        {
            healthScript.turn(1);
            healthScript.damage = Random.Range(minDamage, maxDamage + 1);
        }       
    }

    public void heal()
    {
        if (healthScript.isTurn)
        {
            healthScript.turn(2);
            healthScript.heal = Random.Range(minHealth, maxHealth + 1);
        }
    }

    public void block()
    {
        if (healthScript.isTurn)
        {
            healthScript.turn(3);
            healthScript.block = Random.Range(minBlock, maxblock + 1);
        }
    }

    public void multiplier()
    {
        if (healthScript.isTurn)
        {
            healthScript.turn(4);
            healthScript.multiplier = Random.Range(1, 10);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthScript : MonoBehaviour
{
    public float health = 100;
    public float armor = 100;

    public float blockStat = 0;

    public bool isDead = false;

    public bool isPlayer = false;

    public int choice = 0;

    public bool isTurn = false;


    public int damage = 0;

    public int heal = 0;

    public int block = 0;

    public int multiplier = 1;

    public Text healthText;

    public Text armorText;
 
    public healthScript currentHealthScript;

    public healthScript thisHealthScript;

    public enemyControllScript enemyControllScript;

    [HideInInspector]
    
    public bool isSelf = false;
    // 1 for damage, 2 for heal, 3 for block, and 4 for multiplier

    void Start()
    {
        
    } 


    void Update()
    {
        
        if (isDead == true) 
        {
            die();
        }

        if (isTurn)
        {   
            isTurn = false;
            turn(choice);
            
        }
        if (Input.GetMouseButtonDown(0))
        {
            currentEnemy();
        }

        healthText.text = "Health: " + health.ToString();
        armorText.text = "Armor: " + armor.ToString();
    
        
    }
    
    
    public void currentEnemy()
    {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Perform the raycast and check if it hits something
            if (Physics.Raycast(ray, out hit))
            {
                // Try to get the HealthScript component on the hit object
                healthScript healthScript = hit.collider.GetComponent<healthScript>();
                if (healthScript != null)
                {
                    isSelf = false;
                } else {
                    isSelf = true;
                    healthScript = thisHealthScript;
                }
                
            }
    }
    
    
    public void Attack(float _damage)
    {
        currentHealthScript.takeDamage(_damage);
    }
    public void Heal(float _health) 
    {
            if (health == 100 && armor < 100) {
                armor += _health;
                
            } else if (health < 100) {
                _health -= (100 - health);
                health += (100 - health);
                armor += health;
                  
            }


            if (health > 100) 
            {
                health = 100;
            }
            if (armor > 100)
            {
                armor = 100;
            }
    } 

    

    public void takeDamage(float damage) 
    {   
        if (blockStat > 0)
        {
            blockStat -= damage;
            if (blockStat < 0)
            {
                blockStat = 0;
            }
            return;
        }
        if (armor > 0) 
        {
            armor -= damage;
        } else if (health > 0)
        {
            health -= damage;
        } 

        if (health <= 0 && armor <= 0) { 
            isDead = true;
        } 
        
    }

    void die() 
    {
        //be dead
    }

    public void turn(int _choice) 
    {
        if (_choice == 1) 
        {
            Attack(damage * multiplier);
            multiplier = 1;
        }
        if (_choice == 2)
        {
            Heal(heal * multiplier);
            multiplier = 1;
        }
        if (choice == 3)
        {
            blockStat += (block * multiplier);
            block = 0;

            multiplier = 1;
        }
        if (choice == 4)
        {
            multiplier = Random.Range(3, 11);
        }

        isTurn = false;
        enemyControllScript.isTurn = true;
    }
}
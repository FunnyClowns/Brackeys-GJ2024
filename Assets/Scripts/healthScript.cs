using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthScript : MonoBehaviour
{
    public float health = 100;
    public float armor = 100;

    public bool isDead = false;

    public bool isPlayer = false;

    //healthScript eenemyHealthScript;

    void Start()
    {
        
    } 


    void Update()
    {
        if (isPlayer)
        {
            //UpdateHealthBar();
        }
        
        if (isDead == true) 
        {
            die();
        }
        if (Input.GetMouseButtonDown(0))
        {
            Attack(1);
        }

    
        
    }

    
    public void Attack(float _damage)
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
                    healthScript.takeDamage(_damage);
                    Debug.Log("hit");
                }
            
        }
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



}


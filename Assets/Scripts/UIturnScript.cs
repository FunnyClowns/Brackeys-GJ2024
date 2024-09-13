using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIturnScript : MonoBehaviour
{
    public healthScript healthScript; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void attack()
    {
        if (healthScript.isTurn)
        {
            healthScript.turn(1);
        }       
    }

    public void heal()
    {
        if (healthScript.isTurn)
        {
            healthScript.turn(2);
        }
    }

    public void block()
    {
        if (healthScript.isTurn)
        {
            healthScript.turn(3);
        }
    }

    public void multiplier()
    {
        if (healthScript.isTurn)
        {
            healthScript.turn(4);
        }
    }
}

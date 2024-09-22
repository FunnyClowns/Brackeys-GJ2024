using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showTextScript : MonoBehaviour
{
   public GameObject showOrHide;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void showHideFunc()
    {
        if (showOrHide.activeInHierarchy)
        {
            showOrHide.SetActive(false);
        } else 
        {
            showOrHide.SetActive(true);
        }
    }
}

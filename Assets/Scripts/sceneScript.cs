using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneScript : MonoBehaviour
{

    public string sceneToLoad;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}

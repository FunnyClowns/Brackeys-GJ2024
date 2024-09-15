using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] SceneAsset targetScene;
    [SerializeField] AudioSource clickSound;

    public void OnButtonClick(){
        SceneManager.LoadScene(targetScene.name);

        clickSound.Play();
    }
}

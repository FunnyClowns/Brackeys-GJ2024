using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] string targetScene;
    [SerializeField] AudioSource clickSound;

    public void OnButtonClick(){
        SceneManager.LoadScene(targetScene);

        clickSound.Play();
    }
}

using UnityEngine;

public class ChangePanel : MonoBehaviour
{

    [SerializeField] GameObject currentPanel;   
    [SerializeField] GameObject targetPanel;

    [SerializeField] AudioSource clickSound;

    public void OnButtonClick(){
        targetPanel.SetActive(true);
        currentPanel.SetActive(false);

        clickSound.Play();
    }

    public void OnActiveClick(){
        targetPanel.SetActive(true);

        clickSound.Play();
    }

    public void OnDeactiveClick(){
        targetPanel.SetActive(false);

        clickSound.Play();
    }
}

using UnityEngine;

public class KeyUI : MonoBehaviour{
    [SerializeField] SpriteRenderer KeyButton;

    public void ShowKeyUI(){
        KeyButton.enabled = true;
    }

    public void HideKeyUI(){
        KeyButton.enabled = false;
    }   


}
using UnityEngine;

public class CookTrigger : MonoBehaviour{
    
    [SerializeField] NearbyDetection nearbyDetection;

    [SerializeField] SpriteRenderer KeyButton;

    void Start(){
        nearbyDetection.triggerEvent.AddListener(ShowKeyButton);
        nearbyDetection.untriggerEvent.AddListener(HideKeyButton);
    }

    void ShowKeyButton(){
        KeyButton.enabled = true;
    }

    void HideKeyButton(){
        KeyButton.enabled = false;
    }
}
using UnityEngine;

public class TrashChecker : MonoBehaviour, IClickable{

    [SerializeField] TrashManager trashManager;
    [SerializeField] PlayerController playerController;

    [SerializeField] SpriteRenderer SR_Trash;
    [SerializeField] Sprite mainSprite;
    [SerializeField] Sprite nearbySprite;

    [SerializeField] AudioSource trashOpenSound;
    bool canPlaySound = true;

    bool canTrigger(){
        return playerController.isCarryFood || playerController.isCarryMeat;
    }

    public void Interact(){
        if (canTrigger()){
            trashManager.TriggerThrowItem();

            Debug.Log("Test");
        }

    }

    public void OnNearby(){
        SR_Trash.sprite = nearbySprite;

        if (canPlaySound){
            canPlaySound = false;
            trashOpenSound.Play();
        }
    }

    public void OnFar(){
        SR_Trash.sprite = mainSprite;
        
        canPlaySound = true;
    }
}
using UnityEngine;

public class TrashManager : MonoBehaviour{

    [SerializeField] PlayerController playerController;

    [SerializeField] AudioSource trashSound;
    
    public void TriggerThrowItem(){
        playerController.ThrowItem();

        trashSound.Play();
    }
}
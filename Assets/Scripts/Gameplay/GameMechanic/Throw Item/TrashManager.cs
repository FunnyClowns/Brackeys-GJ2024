using UnityEngine;

public class TrashManager : MonoBehaviour{

    [SerializeField] PlayerController playerController;
    
    public void TriggerThrowItem(){
        playerController.ThrowItem();
    }
}
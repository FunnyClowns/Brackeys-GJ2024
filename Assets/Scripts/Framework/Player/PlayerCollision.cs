using UnityEngine;

public class PlayerCollision : MonoBehaviour{

    [HideInInspector] public GameObject onCollidingObject;

    void OnTriggerStay2D(Collider2D col){
        onCollidingObject = col.gameObject;
    }

    void OnTriggerExit2D(Collider2D col){
        if (col.gameObject == onCollidingObject){
            onCollidingObject = null;
        }
    }

}
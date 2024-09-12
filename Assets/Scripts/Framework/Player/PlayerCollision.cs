using UnityEngine;

public class PlayerCollision : MonoBehaviour{

    [HideInInspector] public GameObject onCollidingObject;

    void OnTriggerEnter2D(Collider2D col){
        onCollidingObject = col.gameObject;

        Debug.Log(onCollidingObject.name);
    }

    void OnTriggerExit2D(Collider2D col){
        if (col.gameObject == onCollidingObject){
            onCollidingObject = null;
        }
    }

}
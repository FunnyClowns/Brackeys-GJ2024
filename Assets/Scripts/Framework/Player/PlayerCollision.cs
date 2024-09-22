using UnityEngine;

public class PlayerCollision : MonoBehaviour{

    [HideInInspector] public GameObject onCollidingObject;

    void OnTriggerStay2D(Collider2D col){
        onCollidingObject = col.gameObject;

        if (onCollidingObject.TryGetComponent<IClickable>(out IClickable clickable)){
            clickable.OnNearby();
        }
    }

    void OnTriggerExit2D(Collider2D col){
        if (col.gameObject == onCollidingObject){
           if (onCollidingObject.TryGetComponent<IClickable>(out IClickable clickable)){
            clickable.OnFar();
        }

            onCollidingObject = null;
        }
    }

}
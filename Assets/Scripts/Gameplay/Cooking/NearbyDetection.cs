using UnityEngine;
using UnityEngine.Events;

public class NearbyDetection : MonoBehaviour
{
    [SerializeField] public UnityEvent triggerEvent;
    [SerializeField] public UnityEvent untriggerEvent;

    [SerializeField] SpriteRenderer sprite;

    bool isNearby;

    void OnTriggerEnter2D(Collider2D col){
        if (col.CompareTag("Player")){
            triggerEvent.Invoke();
            isNearby = true;
            sprite.enabled = true;
        }
    }

    void OnTriggerExit2D(Collider2D col){
        if (col.CompareTag("Player")){
            untriggerEvent.Invoke();
            isNearby = false;  
            sprite.enabled = false; 
        }
    }

    public bool isPlayerNearby(){
        return isNearby;
    }

}

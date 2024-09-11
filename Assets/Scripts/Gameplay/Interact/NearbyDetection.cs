using UnityEngine;

public class NearbyDetection : MonoBehaviour
{

    [SerializeField] SpriteRenderer sprite;


    void OnTriggerEnter2D(Collider2D col){
        if (col.CompareTag("Player")){
            sprite.enabled = true;
        }
    }

    void OnTriggerExit2D(Collider2D col){
        if (col.CompareTag("Player")){
            sprite.enabled = false; 
        }
    }

}

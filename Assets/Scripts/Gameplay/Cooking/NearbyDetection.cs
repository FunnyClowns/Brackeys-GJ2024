using UnityEngine;
using UnityEngine.Events;

public class NearbyDetection : MonoBehaviour
{
    [SerializeField] public UnityEvent triggerEvent;
    [SerializeField] public UnityEvent untriggerEvent;

    void OnTriggerEnter2D(){
        triggerEvent.Invoke();
    }

    void OnTriggerExit2D(){
        untriggerEvent.Invoke();
    }

}

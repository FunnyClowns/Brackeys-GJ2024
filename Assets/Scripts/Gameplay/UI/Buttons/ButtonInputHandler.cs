using UnityEngine;
using UnityEngine.Events;

public class ButtonCaller : MonoBehaviour
{
    [SerializeField] UnityEvent targetEvent;
    public void OnClickButton(){
        targetEvent.Invoke();
    }
}

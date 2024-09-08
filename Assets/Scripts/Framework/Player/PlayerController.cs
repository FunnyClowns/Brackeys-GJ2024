using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [HideInInspector] public SpriteRenderer sprite;

    void Start(){
        sprite = GetComponent<SpriteRenderer>();
    }
}

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] SpriteRenderer foodPlate;
    [HideInInspector] public bool isCarryFood;

    public void TakeFood(){
        isCarryFood = true;
        foodPlate.enabled = true;
    }

    public void PlaceFood(){
        isCarryFood = false;
        foodPlate.enabled = false;
    }
}

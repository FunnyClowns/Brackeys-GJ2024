using UnityEngine;

public class PlacementManager : MonoBehaviour {

    [SerializeField] PlayerController playerController;
    [SerializeField] SpriteRenderer mealsPlateSprite;
    [SerializeField] SpriteRenderer tablePlateSprite;

    [HideInInspector] public bool isTableFull;

    public void OnTriggerPlaceFood(){
        tablePlateSprite.sprite = mealsPlateSprite.sprite;
        playerController.PlaceFood();

        isTableFull = true;
    }

    public void OnTriggerTakeFood(){
        playerController.TakeFood(tablePlateSprite.sprite);
        tablePlateSprite.sprite = null;

        isTableFull = false;
    }
}
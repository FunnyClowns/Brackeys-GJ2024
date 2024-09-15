using UnityEngine;

public class TableManager: MonoBehaviour {

    [SerializeField] PlayerController playerController;
    [SerializeField] SpriteRenderer SR_playerItem;
    [SerializeField] SpriteRenderer SR_tablePlateSprite;
    [SerializeField] Sprite emptyPlateSprite;

    [HideInInspector] public bool isTableFull;

    public void OnTriggerPlaceFood(){
        SR_tablePlateSprite.sprite = SR_playerItem.sprite;
        playerController.PlaceFood();

        isTableFull = true;
    }

    public void OnTriggerTakeFood(){
        playerController.TakeFood(SR_tablePlateSprite.sprite);
        SR_tablePlateSprite.sprite = emptyPlateSprite;

        isTableFull = false;
    }
}
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public SpriteRenderer playerItem;
    [SerializeField] List<Sprite> mealsSprites = new List<Sprite>();
    [HideInInspector] public bool isCarryFood;
    [HideInInspector] public bool isCarryMeat = false;

    public void TakeFood(Sprite sprite){
        isCarryFood = true;

        if (sprite == null){
            SetRandomMealSprite();

        } else {

            SetMealSprite(sprite);

        }
        playerItem.enabled = true;
    }

    public void PlaceFood(){
        isCarryFood = false;
        playerItem.enabled = false;
    }

    void SetRandomMealSprite(){

        int randomNum = Random.Range(0, mealsSprites.Count);

        playerItem.sprite = mealsSprites[randomNum];
    }

    void SetMealSprite(Sprite sprite){
        playerItem.sprite = sprite;
    }
}

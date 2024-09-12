using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] SpriteRenderer mealsPlate;
    [SerializeField] List<Sprite> mealsSprites = new List<Sprite>();
    [HideInInspector] public bool isCarryFood;

    public void TakeFood(Sprite sprite){
        isCarryFood = true;

        if (sprite == null){
            SetRandomMealSprite();

        } else {

            SetMealSprite(sprite);

        }
        mealsPlate.enabled = true;
    }

    public void PlaceFood(){
        isCarryFood = false;
        mealsPlate.enabled = false;
    }

    void SetRandomMealSprite(){

        int randomNum = Random.Range(0, mealsSprites.Count);

        mealsPlate.sprite = mealsSprites[randomNum];
    }

    void SetMealSprite(Sprite sprite){
        mealsPlate.sprite = sprite;
    }
}

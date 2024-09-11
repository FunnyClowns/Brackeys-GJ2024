using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] SpriteRenderer mealsPlate;
    [SerializeField] List<Sprite> mealsSprites = new List<Sprite>();
    [HideInInspector] public bool isCarryFood;

    public void TakeFood(){
        isCarryFood = true;
        SetRandomMealsSprite();
        mealsPlate.enabled = true;
    }

    public void PlaceFood(){
        isCarryFood = false;
        mealsPlate.enabled = false;
    }

    void SetRandomMealsSprite(){

        int randomNum = Random.Range(0, mealsSprites.Count);

        mealsPlate.sprite = mealsSprites[randomNum];
    }
}

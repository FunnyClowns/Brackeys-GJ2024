using UnityEngine;
using TMPro;

public class FridgeManager : MonoBehaviour {

    [SerializeField] public int meatAmount = 999;

    [SerializeField] PlayerController playerController;
    [SerializeField] Sprite meatSprite;

    [SerializeField] TextMeshProUGUI ingredientsCountText;

    void Start(){
        ingredientsCountText.text = meatAmount.ToString();
    }
    
    public void TriggerTakeMeat(){
        DecreaseMeatAmount();

        playerController.playerItem.sprite = meatSprite;
        playerController.isCarryMeat = true;
        playerController.playerItem.enabled = true;
    }

    void AddMeatAmount(){
        meatAmount += 1;

        ingredientsCountText.text = meatAmount.ToString();
    }

    void DecreaseMeatAmount(){
        meatAmount -= 1;

        ingredientsCountText.text = meatAmount.ToString();
        Debug.Log("Meat Amount : " + meatAmount);
    }


}
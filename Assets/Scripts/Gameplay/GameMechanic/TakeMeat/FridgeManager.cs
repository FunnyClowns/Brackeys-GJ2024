using UnityEngine;

public class FridgeManager : MonoBehaviour {

    [HideInInspector] public int meatAmount = 999;

    [SerializeField] PlayerController playerController;
    [SerializeField] Sprite meatSprite;
    
    public void TriggerTakeMeat(){
        DecreaseMeatAmount();

        playerController.playerItem.sprite = meatSprite;
        playerController.isCarryMeat = true;
        playerController.playerItem.enabled = true;
    }

    void DecreaseMeatAmount(){
        meatAmount -= 1;

        Debug.Log("Meat Amount : " + meatAmount);
    }


}
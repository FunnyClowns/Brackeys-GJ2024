using UnityEngine;

public class ServeManager : MonoBehaviour
{
    [SerializeField] PlayerController playerController;
    [SerializeField] CookingTableManager cookingManager;

    public void TriggerServe(){
        Debug.Log("Served");
        playerController.PlaceFood();
        cookingManager.DecreaseMealsOrder();
    }
}

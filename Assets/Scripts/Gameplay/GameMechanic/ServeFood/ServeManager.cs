using UnityEngine;

public class ServeManager : MonoBehaviour
{
    [SerializeField] PlayerController playerController;
    [SerializeField] CookingTableManager cookingManager;
    [SerializeField] ClientsController clientsController;

    public void TriggerServe(){
        Debug.Log("Served");
        playerController.PlaceFood();
        cookingManager.DecreaseMealsOrder();
        clientsController.ResetTimer();
    }
}

using TMPro;
using UnityEngine;

public class ServeManager : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] PlayerController playerController;
    [SerializeField] CookingTableManager cookingManager;
    [SerializeField] ClientsController clientsController;

    [SerializeField] TextMeshProUGUI clientTargetText;

    int clientToFeed;

    void Start(){
        clientToFeed = gameManager.ClientsToFeed;
        clientTargetText.text = clientToFeed.ToString();
    }

    public void TriggerServe(){
        Debug.Log("Served");
        playerController.PlaceFood();
        cookingManager.DecreaseMealsOrder();
        clientsController.ResetTimer();
        DecreaseClientToFeed();
    }

    void DecreaseClientToFeed(){
        clientToFeed -= 1;

        clientTargetText.text = clientToFeed.ToString();

        if (clientToFeed <= 0){
            gameManager.GameWin();
        }
    }
}

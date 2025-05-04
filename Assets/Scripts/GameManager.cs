using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] PlayerMovement playerMovement;
    [SerializeField] TextMeshProUGUI currentCoin;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentCoin.text = "Coin Collected: " + playerMovement.coinCount.ToString() + "/20";
    }
}

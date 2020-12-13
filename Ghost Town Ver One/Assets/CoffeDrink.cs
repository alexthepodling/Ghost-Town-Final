using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoffeDrink : MonoBehaviour
{
    public GameObject coffeeDrink;
    public GameObject interactionButton;
    public Button interactionEnabler;
    public GameObject coinText;
    public GameObject settingsButton;

    private bool playerInArea;

    private void Awake()
    {
        interactionButton.SetActive(false);
        coffeeDrink.SetActive(false);
        Button btn = interactionEnabler.GetComponent<Button>();
        btn.onClick.AddListener(Drink);
    }

    public void Drink()
    {
        if (playerInArea == true)
        {
            coffeeDrink.SetActive(true);
            coinText.SetActive(false);
            settingsButton.SetActive(false);
        }
    }

    public void Exit()
    {
        coffeeDrink.SetActive(false);
        coinText.SetActive(true);
        settingsButton.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        playerInArea = true;
        interactionButton.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        playerInArea = false;
        interactionButton.SetActive(false);
        coffeeDrink.SetActive(false);
    }
}

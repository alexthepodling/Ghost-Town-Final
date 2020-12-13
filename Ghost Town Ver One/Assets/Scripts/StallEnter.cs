using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StallEnter : MonoBehaviour
{
    public GameObject UIShopInterface;
    public GameObject interactionButton;
    public Button interactionEnabler;

    private bool playerInArea;

    private void Awake()
    {
        interactionButton.SetActive(false);
        UIShopInterface.SetActive(false);
        Button btn = interactionEnabler.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    public void TaskOnClick()
    {
        if(playerInArea == true)
        {
            UIShopInterface.SetActive(true);
        }
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
        UIShopInterface.SetActive(false);
    }
}

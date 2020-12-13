using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Reveal : MonoBehaviour
{
    public GameObject fishingGame;
    public GameObject interactionButton;
    public Button interactionEnabler;

    void OnLoadCallback(Scene scene, LoadSceneMode mode)
    {
        interactionButton = GameObject.FindGameObjectWithTag("Interact");
        //interactionEnabler = 
    }

    private void Awake()
    {
        SceneManager.sceneLoaded += this.OnLoadCallback;

        //interactionButton = GameObject.FindGameObjectWithTag("Interact");

        interactionButton.SetActive(false);
        fishingGame.SetActive(false);
        Button btn = interactionEnabler.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        fishingGame.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        interactionButton.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        interactionButton.SetActive(false);
        fishingGame.SetActive(false);
    }
}

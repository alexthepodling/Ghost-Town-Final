using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterInteract : MonoBehaviour
{
    public GameObject interactionButton;
    public Button interactionEnabler;
    public GameObject panel;
    public GameObject helpPanel;
    public Button optionOne;
    public Button optionTwo;
    public Button optionThree;
    public GameObject startTimer;
    public GameObject coolObjects;

    private bool playerInArea;

    public static bool isGamePaused = false;

    public void OptionOne()
    {
        panel.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }

    public void OptionTwo()
    {
        panel.SetActive(false);
        Time.timeScale = 1f;
        startTimer.SetActive(true);
        coolObjects.SetActive(true);
        //show objects
        //delete objects when timer ends
    }

    public void OptionThree()
    {
        helpPanel.SetActive(true);
        panel.SetActive(false);
    }

    public void BackButton()
    {
        helpPanel.SetActive(false);
        panel.SetActive(true);
    }

    private void Awake()
    {
        Debug.Log("Awake");
        panel.SetActive(false);
        startTimer.SetActive(false);
        interactionButton.SetActive(false);
        coolObjects.SetActive(false);
        Button btn = interactionEnabler.GetComponent<Button>();
        btn.onClick.AddListener(InteractChar);
    }

    public void InteractChar()
    {
        if (playerInArea == true)
        {
            Time.timeScale = 0f;
            isGamePaused = true;
            panel.SetActive(true);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        /*if(other.gameObject.tag == "Player")
        {
            Debug.Log("Entered");
            playerInArea = true;
            interactionButton.SetActive(true);
        }*/

        Debug.Log("Entered");
        playerInArea = true;
        interactionButton.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        playerInArea = false;
        interactionButton.SetActive(false);
    }
    //public void ResumeGame()
    //{
     //   Time.timeScale = 1f;
      //  isGamePaused = false;
    //}

    //public void PauseGame()
    //{
     //   Time.timeScale = 0f;
      //  isGamePaused = true;
    //}
}

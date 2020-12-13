using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostHuntMinigame : MonoBehaviour
{
    public GameObject uiButton;

    // Start is called before the first frame update
    void Awake()
    {
        GetComponent<PauseTheWorld>().BeginMinigame();
        GetComponent<PauseTheWorld>().PauseGame();
        uiButton.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        uiButton.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        uiButton.SetActive(false);
    }


}

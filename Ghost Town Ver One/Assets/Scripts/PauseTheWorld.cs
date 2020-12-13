using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseTheWorld : MonoBehaviour
{
    public static bool isGamePaused = false;
    public GameObject camera1;
    public GameObject camera2;
    public GameObject joystick;
    public GameObject ghostControls;

    [SerializeField] GameObject pauseMenu;

    private Player playerInput;

    private void Awake()
    {
        playerInput = new Player();
    }


    public void ResumeGame()
    {
        Time.timeScale = 1f;
        isGamePaused = false;
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        isGamePaused = true;
    }

    public void BeginMinigame()
    {
        Time.timeScale = 0f;
        isGamePaused = true;
        ghostControls.SetActive(true);
        joystick.SetActive(false);
        camera1.SetActive(false);
        camera2.SetActive(true);
        playerInput.Disable();
        //Disable controls + joystick
        //Switch camera
    }

    public void ReturnToMain()
    {
        Time.timeScale = 1f;
        isGamePaused = false;
        ghostControls.SetActive(false);
        joystick.SetActive(true);
        camera1.SetActive(true);
        camera2.SetActive(false);
        playerInput.Enable();
        //EnableControls + joystick
        //Switch back camera
    }
}

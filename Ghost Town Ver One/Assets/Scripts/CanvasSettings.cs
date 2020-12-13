using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class CanvasSettings : MonoBehaviour
{
    public AudioMixer audioMixer;

    public Dropdown resolutionDropdown;

    public static bool isGamePaused = false;

    [SerializeField] GameObject pauseMenu;

    public GameObject settingsButton;

    public GameObject settingsMenu;

    public GameObject constantUI;

    public GameObject colourMenu;
    public GameObject bottomPlayer;
    public GameObject topPlayer;
    public Material material1;
    public Material material2;
    public Material material3;
    public Button material1Button;
    public Button material2Button;
    public Button material3Button;

    //Set colours
    public void SetColour1()
    {
        bottomPlayer.GetComponent<MeshRenderer>().material = material1;
        topPlayer.GetComponent<MeshRenderer>().material = material1;
    }
    public void SetColour2()
    {
        bottomPlayer.GetComponent<MeshRenderer>().material = material2;
        topPlayer.GetComponent<MeshRenderer>().material = material2;
    }
    public void SetColour3()
    {
        bottomPlayer.GetComponent<MeshRenderer>().material = material3;
        topPlayer.GetComponent<MeshRenderer>().material = material3;
    }

    public void ColourBack()
    {
        colourMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }

    public void ColourEnter()
    {
        colourMenu.SetActive(true);
        pauseMenu.SetActive(false);
    }

    //Settings Menu
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    //PAUSE MENU
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
        settingsButton.SetActive(true);
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
        settingsButton.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();

        Debug.Log("Quit");
    }

    public void SettingsMenu()
    {
        settingsMenu.SetActive(true);
        pauseMenu.SetActive(false);
    }

    public void BackBut()
    {
        settingsMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }
}

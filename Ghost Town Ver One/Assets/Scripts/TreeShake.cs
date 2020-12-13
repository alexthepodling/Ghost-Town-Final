using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreeShake : MonoBehaviour
{
    public GameObject interactionButton;
    public Button interactionEnabler;
    public ParticleSystem fallingLeaves;

    public GameObject ObjectToCreate;

    private bool playerInArea;

    private void Awake()
    {
        interactionButton.SetActive(false);
        Button btn = interactionEnabler.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnTree);
    }

    public void TaskOnTree()
    {
        if (playerInArea == true)
        {
            fallingLeaves.Play();
            if (Random.value > 0.5) //%50 percent chance
            {
                Debug.Log("Coin appeared!");
                Instantiate(ObjectToCreate, new Vector3(33.859f, 0.139f, -14.272f), Quaternion.identity);
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        playerInArea = true;
        interactionButton.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        playerInArea = false;
        interactionButton.SetActive(false);
    }
}

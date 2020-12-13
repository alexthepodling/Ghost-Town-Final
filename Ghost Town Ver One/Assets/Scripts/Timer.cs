using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //Timer
    public GameObject textDisplay;
    public int secondsLeft = 30;
    public bool takingAway = false;
    public GameObject coolObjs;

    // Start is called before the first frame update
    void Start()
    {
        textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
        coolObjs.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
        if (secondsLeft < 1)
        {
            textDisplay.SetActive(false);
            coolObjs.SetActive(false);
        }
    }
    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        if(secondsLeft < 10)
        {
            textDisplay.GetComponent<Text>().text = "00:0" + secondsLeft;
        }
        else
        {
            textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
        }
        takingAway = false;
    }
}

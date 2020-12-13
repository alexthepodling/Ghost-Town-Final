using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableButtonAtStart : MonoBehaviour
{
    public Image buttonImage;
    private void Start()
    {
        buttonImage.gameObject.SetActive(false);
    }
}

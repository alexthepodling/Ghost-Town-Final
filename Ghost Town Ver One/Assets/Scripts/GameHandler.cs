﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
    public Text coinText;
    public int coins = 0;

    private void Update()
    {
    coinText.text = "Coins: " + coins;
    }
}
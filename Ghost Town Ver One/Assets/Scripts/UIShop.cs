using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIShop : MonoBehaviour
{
    public int money;
    public Text moneytext;
    public Text inventoryText;

    public GameHandler GH;

    private void Update()
    {
        GH = GameObject.Find("Canvas").GetComponent<GameHandler>();

        money = GH.coins;
        moneytext = GH.coinText;
    }

    public void additem(string item)
    {
        moneytext.text = money.ToString();
        inventoryText.text = "Just bought: " + item;
    }

    public void loseMoney(int cost) 
    { 
        GH.coins -= cost; 
    }
}

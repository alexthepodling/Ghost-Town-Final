using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int cost;
    public string itemName;
    public GameObject itemReal;
    public GameObject itemHolo;

    private void Start()
    {
        itemReal.SetActive(false);
    }

    public void bought()
    {
        Debug.Log("Enough Money");  if (GetComponentInParent<UIShop>().money >= cost)
        {
            Debug.Log("Bought");
            GetComponentInParent<UIShop>().loseMoney(cost);
            //GetComponentInParent<UIShop>().money -= cost;

            //GetComponentInParent<UIShop>().moneytext = "Coins: " + coinTotal;
            //coinText.text = "Coins: " + coins;
            GetComponentInParent<UIShop>().additem(itemName);
            itemHolo.SetActive(false);
            itemReal.SetActive(true);
        }
    }
}

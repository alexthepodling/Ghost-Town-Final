using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPoint : MonoBehaviour
{
    public GameHandler GH;

    private void Start()
    {
        GH = GameObject.Find("Canvas").GetComponent<GameHandler>();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision Triggered");
        GH.coins++;
        Destroy(gameObject);
    }
}

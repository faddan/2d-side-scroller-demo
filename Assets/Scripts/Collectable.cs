using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private static int coinCount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            coinCount++;
            Debug.Log("Coin count: " + coinCount);
            Destroy(gameObject);
        }
    }
}

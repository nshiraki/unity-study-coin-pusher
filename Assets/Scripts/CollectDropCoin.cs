using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectDropCoin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
        }
    }
}

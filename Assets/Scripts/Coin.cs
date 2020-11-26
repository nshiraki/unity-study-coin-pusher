using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
	private void FixedUpdate()
	{
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 force = new Vector3(0, -9.8f, 0);// Vector3.down;
        rb.AddForce(force, ForceMode.Impulse);
    }
}

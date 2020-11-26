using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour
{
	Vector3 pusherPosition;
	public float speed;

    // Start is called before the first frame update
    void Start()
    {
		pusherPosition = transform.position;
	}

    // Update is called once per frame
    void Update()
    {
		float z = Mathf.Sin(Time.time * speed);
		transform.position = pusherPosition + new Vector3(0, 0, z);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checker : MonoBehaviour
{
	// GameControllerにアクセスする変数
	GameController gameController;
	public float vx;
	const float X_MAX = 2.5f;

	// Start is called before the first frame update
	void Start()
	{
		gameController = GameObject.Find("GameController").GetComponent<GameController>();
	}

	// Update is called once per frame
	void Update()
	{
		Move();
	}

	private void Move()
	{

		Vector3 p = transform.position;
		p.x += vx * Time.deltaTime;
		if (p.x > X_MAX || p.x < -X_MAX)
		{
			// 反転させる
			vx *= -1;
			Mathf.Clamp(p.x, -X_MAX, X_MAX);
		}
		transform.position = p;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Coin"))
		{
			gameController.AddScore();
			Destroy(other.gameObject);
		}
	}
}

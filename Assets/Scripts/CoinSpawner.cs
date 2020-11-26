using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
	public GameObject coinPrefab;
	public float moveSpeed;
	GameController gameController;
	Vector3 spawnerPosition;
	float countTime;

	// Start is called before the first frame update
	void Start()
	{
		gameController = GameObject.Find("GameController").GetComponent<GameController>();
		spawnerPosition = transform.position;
	}

	// Update is called once per frame
	void Update()
	{
		Move();
	}

	// Spawnerの移動
	private void Move()
	{
		countTime += Time.deltaTime;

		float x = Mathf.Sin(Time.time * moveSpeed);
		transform.position = spawnerPosition + new Vector3(x, 0, 0);

		if (Input.GetKey("space"))
		{
			if (countTime > 0.2f)
			{
				SpawnCoin();
				countTime = 0;
			}
		}
	}
	// コイン投入
	void SpawnCoin()
	{
		Vector3 SpawnerPosition = this.transform.position;
		//SpawnerPosition.x = SpawnerPosition.x + 90;
		Quaternion q = Quaternion.Euler(SpawnerPosition);
		Instantiate(coinPrefab, this.transform.position, q);
	}
}

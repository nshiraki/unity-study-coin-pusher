using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
	public Text ScoreText;
	public GameObject payout;
	public GameObject coinPrefab;
	public int score;

	// Start is called before the first frame update
	void Start()
	{
		// 初期のコインをステージに払い出す
		StartCoroutine(PayoutCoroutine(40, 0.08f));
	}

	// Update is called once per frame
	void Update()
	{
		ScoreText.text = "SCORE:" + score;
	}

	public void AddScore()
	{
		score++;
	}

	public void Payout(int num)
	{
		StartCoroutine(PayoutCoroutine(num, 0.08f));
	}

	IEnumerator PayoutCoroutine(int num, float seconds)
	{
		for (int i = 0; i < num; i++)
		{
			float x = Random.Range(-35, 35) * 0.1f;
			float z = Random.Range(-25, 30) * 0.1f;
			Instantiate(coinPrefab,
				payout.transform.position + new Vector3(x, 0, z),
				payout.transform.rotation);
			yield return new WaitForSeconds(seconds);
		}
	}
}

using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour 
{

	PlayerData playerData;

	void Start()
	{
		playerData = FindObjectOfType<PlayerData>();
	}

	void OnTriggerEnter(Collider colliderData)
	{

		if(colliderData.gameObject.CompareTag("PlayerBullet"))
		{
			playerData.IncrementPlayerScore();
			Destroy(gameObject);
		}
		else if(colliderData.gameObject.CompareTag("Player"))
		{
			Debug.Log("GameOver");
		}


	}


}

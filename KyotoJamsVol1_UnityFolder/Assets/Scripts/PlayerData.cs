using UnityEngine;
using System.Collections;

public class PlayerData : MonoBehaviour 
{
	EnemySpawnersManager enemySpawnersManager;

	int playerScore = 0;

	void Start()
	{
		enemySpawnersManager = FindObjectOfType<EnemySpawnersManager>();
	}


	public void IncrementPlayerScore()
	{
		playerScore += 1;
		enemySpawnersManager.OnPlayerScoreIncremented(playerScore);
	}

	public int GetPlayerScore()
	{
		return playerScore;
	}


}

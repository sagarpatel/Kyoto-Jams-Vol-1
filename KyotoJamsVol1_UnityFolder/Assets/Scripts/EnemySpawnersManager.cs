using UnityEngine;
using System.Collections;

public class EnemySpawnersManager : MonoBehaviour 
{
	public EnemiesSpawner[] enemySpawners;

	float currentSpawnCooldown = 2.0f;
	float cooldownDecrementerFactor = 0.1f;
	float spawnCooldownFloor = 0.25f;
	float cooldownTimeCounter = 0;

	float currentEnemyMoveSpeed = 0.5f;
	float enemyMoveSpeedCeiling = 2.0f;
	float enemyMoveSpeedIncrementFactor = 0.1f;

	int currentSpawnerIndex = 0;

	void Update()
	{

		cooldownTimeCounter += Time.deltaTime;

		if(cooldownTimeCounter > currentSpawnCooldown )
		{
			cooldownTimeCounter -= currentSpawnCooldown;

			enemySpawners[currentSpawnerIndex].SpawnEnemy(currentEnemyMoveSpeed);


			int currentSpawnersCount = enemySpawners.Length;
			currentSpawnerIndex = (currentSpawnerIndex + 1) % currentSpawnersCount;
		}



	}


	// NEED TO TURN THIS INTO DLEGATE
	public void OnPlayerScoreIncremented(int playerScore)
	{
		currentSpawnCooldown = Mathf.Clamp( (currentSpawnCooldown - cooldownDecrementerFactor * (float)playerScore), spawnCooldownFloor , 5.0f);
		currentEnemyMoveSpeed =  Mathf.Clamp( (currentEnemyMoveSpeed + enemyMoveSpeedIncrementFactor * (float)playerScore ), 0.01f, enemyMoveSpeedCeiling );

	}




}

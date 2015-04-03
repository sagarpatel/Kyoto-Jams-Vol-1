using UnityEngine;
using System.Collections;

public class EnemiesSpawner : MonoBehaviour 
{

	public GameObject enemyPrefab;

	public void SpawnEnemy(float enemySpeed)
	{
		GameObject spawnedEnemy = (GameObject)Instantiate(enemyPrefab);
		spawnedEnemy.transform.parent = transform;
		spawnedEnemy.transform.localPosition = Vector3.zero;
		spawnedEnemy.transform.rotation = transform.rotation;
		spawnedEnemy.GetComponent<ObjectMove>().moveSpeed = enemySpeed;
	}


}

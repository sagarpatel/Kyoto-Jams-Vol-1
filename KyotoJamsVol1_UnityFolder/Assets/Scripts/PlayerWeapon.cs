using UnityEngine;
using System.Collections;

public class PlayerWeapon : MonoBehaviour 
{
	public GameObject bulletPrefab;
	float bulletSpeed = 1.0f;


	void Start()
	{

	}

	public void FireWeapon()
	{
		GameObject firedBullet = (GameObject)Instantiate(bulletPrefab);
		firedBullet.transform.position = transform.position;
		firedBullet.transform.rotation = transform.rotation;
		firedBullet.GetComponent<ObjectMove>().moveSpeed = bulletSpeed;
	}


}

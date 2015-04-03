using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour 
{
	float fireCooldown = 1.0f;
	float fireColldownTimeCounter = 0;
	bool isReadyToFire = true;
	PlayerWeapon playerWeapon;

	void Start()
	{
		playerWeapon = FindObjectOfType<PlayerWeapon>();
	}

	void Update()
	{
		if(isReadyToFire == true)
		{
			/*
			if(Input.touchCount == 1)
			{    
				if(Input.GetTouch(0).phase == TouchPhase.Began)
				{

					Debug.Log("FIRE");
					// FIRE!
					isReadyToFire = false;


				}
			}
			*/
			if(Input.GetMouseButtonDown(0))
			{
				Debug.Log("FIRE");
				// FIRE!
				isReadyToFire = false;
				playerWeapon.FireWeapon();
			}

		}
		else
		{
			fireColldownTimeCounter += Time.deltaTime;

			if(fireColldownTimeCounter > fireCooldown )
			{
				isReadyToFire = true;
				fireColldownTimeCounter = 0;
			}

		}
	}

}

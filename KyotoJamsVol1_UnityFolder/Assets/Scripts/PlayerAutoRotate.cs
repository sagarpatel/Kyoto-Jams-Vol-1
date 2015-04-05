using UnityEngine;
using System.Collections;

public class PlayerAutoRotate : MonoBehaviour 
{
	float rotationCooldown = 1.0f;
	float rotationCooldownTimeConter = 0;
	public AnimationCurve rotationAnimCurve;

	float currentRotationSpeed = 0;
	float rotationSpeedIncrement = 1.5f;
	float maxRotationSpeed = 10.0f;

	void Start()
	{
		currentRotationSpeed = 0;

	}


	void Update()
	{


		currentRotationSpeed += rotationSpeedIncrement * Time.deltaTime;
		currentRotationSpeed = Mathf.Clamp(currentRotationSpeed, 0, maxRotationSpeed);

		transform.Rotate( new Vector3(0, currentRotationSpeed * Time.deltaTime, 0));


		/*
		rotationCooldownTimeConter += Time.deltaTime;

		if(rotationCooldownTimeConter > rotationCooldown)
		{
			rotationCooldownTimeConter -= rotationCooldown;

			StartCoroutine(RotatePlayer());

		}

		*/

	}

	// TODO need to deletegate this
	public void KillRotation()
	{
		currentRotationSpeed = 0;
	}


	/*

	IEnumerator RotatePlayer()
	{

		float animationLength = rotationCooldown * 0.75f;
		float timeCounter = 0;

		Quaternion startRot = transform.rotation;
		Quaternion endRot  = startRot * Quaternion.Euler(0,90,0);

		while(timeCounter < animationLength)
		{
			float step  = rotationAnimCurve.Evaluate(timeCounter/animationLength);
			transform.rotation = Quaternion.Slerp(startRot,endRot,step);
			timeCounter += Time.deltaTime;
			yield return null;
		}
		transform.rotation = endRot;

	}
	*/

}

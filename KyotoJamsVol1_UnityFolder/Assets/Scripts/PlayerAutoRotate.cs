using UnityEngine;
using System.Collections;

public class PlayerAutoRotate : MonoBehaviour 
{
	float rotationCooldown = 1.5f;
	float rotationCooldownTimeConter = 0;
	public AnimationCurve rotationAnimCurve;


	void Update()
	{
		rotationCooldownTimeConter += Time.deltaTime;

		if(rotationCooldownTimeConter > rotationCooldown)
		{
			rotationCooldownTimeConter -= rotationCooldown;

			StartCoroutine(RotatePlayer());

		}



	}


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


}

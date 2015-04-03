using UnityEngine;
using System.Collections;

public class ObjectMove : MonoBehaviour 
{

	public float moveSpeed = 1.0f;

	void Update()
	{
		transform.position += transform.forward * moveSpeed * Time.deltaTime;
	}


}

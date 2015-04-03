using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerScoreText : MonoBehaviour 
{
	string baseText;
	Text scoreText;
	PlayerData playerData;


	void Start()
	{
		scoreText = GetComponent<Text>();
		baseText = scoreText.text;
		playerData = FindObjectOfType<PlayerData>();
	}

	void Update()
	{
		scoreText.text = baseText + playerData.GetPlayerScore().ToString();

	}



}

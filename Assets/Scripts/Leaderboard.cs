﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Leaderboard : MonoBehaviour {

	private int currentHighscore;

	// Use this for initialization
	void Start () {
		currentHighscore = PlayerPrefs.GetInt("highscore", 0); 
		//PlayerPrefs.SetInt("highscore", 0); 
		GetComponent<Text> ().text = "Current Highscore: " + currentHighscore;
		/*int lastScore = PlayerPrefs.GetInt ("lastscore", 0);
		if (lastScore > currentHighscore) {
			PlayerPrefs.SetInt ("highscore", lastScore);
			GetComponent<Text> ().text = "Congratz New Highscore: " + currentHighscore;
			GetComponent<Text> ().color = Color.red;
			Debug.Log ("Congratz new highscore: " + lastScore);
		} else {
			GetComponent<Text> ().text = "Current Highscore: " + currentHighscore;
		}*/
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("escape"))
		{
			Application.Quit();
		}
		if (Input.anyKey && !Input.GetKeyDown(KeyCode.Escape)) {
			SceneManager.LoadScene("Main");
		} 
	}
}

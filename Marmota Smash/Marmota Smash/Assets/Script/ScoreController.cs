using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	private Text scoreLabel;
	private int score = 0;

	// Use this for initialization
	void Start () {
		scoreLabel = GetComponent<Text> ();
		UpdateScoreLabel ();
	}
	
	// Update is called once per frame
	void Update () {
		UpdateScoreLabel ();
	}

	void UpdateScoreLabel() {
		scoreLabel.text = "Score: " + score;
	}

	public void AddScore(int points) {
		score += points;
	}

	public void RemoveScore(int points) {
		score -= points;
	}

	public int GetScore() {
		return score;
	}
}

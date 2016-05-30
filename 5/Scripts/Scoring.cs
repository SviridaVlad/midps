using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scoring : MonoBehaviour {

	int curr_score;
   public Text scoreText;
   float timer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Drifting (int score) {
		timer = 2f;
		curr_score += score;
		scoreText.text = curr_score.ToString();
	}

	void FixedUpdate()
	{
		if (timer > 0)
		{
			timer -= 0.02f;
		}
		else
		{
			PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + curr_score / 100);
			curr_score = 0;
			scoreText.text = "";
		}
	}

}

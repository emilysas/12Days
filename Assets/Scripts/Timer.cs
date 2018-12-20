using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
 
	public float timeLeft = 60;
    public Text textBox;
	public Text ScoreText;
	public List<Text> DayScores = new List<Text>();

	void Start () {
        textBox.text = timeLeft.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		if (timeLeft <= 0)
		{
			Score.CalculateBonus();
			GameObject.Find("ScoreGameOverText").GetComponent<Text>().text = "Game Over";
			GameObject.Find("ScoreGameOver").GetComponent<Text>().text = Score.Total().ToString();
			GameObject.Find("Music").GetComponent<AudioSource>().Stop();
			Time.timeScale = 0;
        }
		else {
			timeLeft -= Time.deltaTime;
			textBox.text = Mathf.Round(timeLeft).ToString();
			ScoreText.text = Score.Total().ToString();
			DayScores.ForEach(day => {
				Debug.Log(day.name);
				Debug.Log(Score.DayScores);
				day.text = Score.DayScores[int.Parse(day.name)].ToString();
				if (day.name == day.text) {
					day.color = new Color(0, 255, 0);
				}
				else {
					day.color = new Color(255, 255, 255);
				}
			});
		}
	}
 
}

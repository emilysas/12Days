using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
 
	public float timeLeft = 60;
    public Text textBox;
	public Text ScoreText;
	public List<Text> DayScores = new List<Text>();
	public GameObject StartButton;

	void Start () {
        textBox.text = timeLeft.ToString();
		Time.timeScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (timeLeft <= 0)
		{
			Score.CalculateBonus();
			GameObject.Find("ScoreGameOverText").GetComponent<Text>().text = "Game Over";
			GameObject.Find("ScoreGameOver").GetComponent<Text>().text = Score.Total().ToString();
			// StartButton.SetActive(true);
			var music = GameObject.Find("Music").GetComponent<AudioSource>();
			StartCoroutine(FadeOut(music, 50f));
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

	public void ClickStart() {
		Time.timeScale = 1;
		StartButton.SetActive(false);
		GameObject.Find("Music").GetComponent<AudioSource>().Play();
	}

	public static IEnumerator FadeOut(AudioSource audioSource, float FadeTime) {
        float startVolume = audioSource.volume;
        while (audioSource.volume > 0) {
            audioSource.volume -= startVolume * Time.deltaTime / FadeTime;
            yield return null;
        }
        audioSource.Stop();
		Time.timeScale = 0;
    }
 
}

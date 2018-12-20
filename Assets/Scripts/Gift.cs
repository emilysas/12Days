using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour {

	private float _speed;
	private int _dayNumber;
	

	void Awake()
	{
		_speed = Random.Range(2.5f, 5f);
	}
	// Use this for initialization
	

	void Start () {
		transform.position = new Vector3(Random.Range(-14.9f, 14.9f), 7, -2);
		if(Random.Range(1, 4) == 1){
			_dayNumber = 5;
		} else {
			_dayNumber = Random.Range(1, 12);
		}
		var presents = Resources.LoadAll<Sprite> ("presents");
		gameObject.GetComponent<SpriteRenderer>().sprite = presents[_dayNumber-1];
	}
	
	// Update is called once per frame
	void Update () {
		transform.position -= transform.up * Time.deltaTime * _speed;
		if (transform.position.y < -10) {
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Sleigh") {
			// Increment counters
			// play sound if complete
			// destroy this
			Debug.Log("Got present");
			Score.Add(_dayNumber);
			GameObject.Find("CollectSound").GetComponent<AudioSource>().Play();
			if (Score.DayScores[5] == 5 && Settings.PlayJustin) {
				Debug.Log("Playing Justin");
				var justin = GameObject.Find("Justin").GetComponent<AudioSource>();
				justin.Play();
				var justinSprite = GameObject.Find("JustinSprite").GetComponent<Justin>().CanMove = true;
				Settings.PlayJustin = false;
			}

			Destroy(gameObject);
		}
	}
}

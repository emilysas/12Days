using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour {

	private float _speed;

	void Awake()
	{
		_speed = Random.Range(0.5f, 1.5f);
	}
	// Use this for initialization
	

	void Start () {
		transform.position = new Vector3(Random.Range(-14.9f, 14.9f), 7, -2);
		var num = Random.Range(0, 11);
		var presents = Resources.LoadAll<Sprite> ("presents");
		gameObject.GetComponent<SpriteRenderer>().sprite = presents[num];
	}
	
	// Update is called once per frame
	void Update () {
		transform.position -= transform.up * Time.deltaTime * _speed;
		if (transform.position.y < -10) {
			Destroy(gameObject);
		}
	}
}

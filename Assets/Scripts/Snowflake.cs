using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowflake : MonoBehaviour {

	private float _size;
	private float _speed;

	// Use this for initialization
	void Awake () {
		_size = Random.Range(0.1f, 0.5f);
		_speed = Random.Range(0.5f, 1.5f);
	}

	void Start() {
		transform.position = new Vector3(Random.Range(-14.9f, 14.9f), 7, -2);
		transform.localScale = new Vector3(_size, _size, 1);
	}
	
	void FixedUpdate()
	{
		transform.position -= transform.up * Time.deltaTime * _speed;
		if (transform.position.y < -10) {
			Destroy(gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}

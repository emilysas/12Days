using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftSpawner : MonoBehaviour {

	public GameObject GiftPrefab;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Time.frameCount % Random.Range(15, 60) == 0) {
			Instantiate(GiftPrefab);
		}
	}
}

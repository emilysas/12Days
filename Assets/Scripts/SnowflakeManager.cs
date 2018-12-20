using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowflakeManager : MonoBehaviour {

	public GameObject Snowflake;
	
	// Use this for initialization
	void Start () {
		
	}

	void FixedUpdate()
	{
		if (Time.frameCount % 15 == 0) {
			//spawn new snowflake
			var snowflake = new Snowflake();
			Instantiate(Snowflake);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

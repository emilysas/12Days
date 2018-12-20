using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Justin : MonoBehaviour {

	// Use this for initialization
	public bool CanMove = false;
	private bool _moveJustinUp = true;
	
	// Update is called once per frame
	void FixedUpdate () {
		if (CanMove && _moveJustinUp && transform.position.y < 0) {
			transform.position += transform.up * Time.deltaTime * 3f;
		}
		else if(transform.position.y >= 0) {
			_moveJustinUp = false;
			// transform.position -= transform.up * Time.deltaTime * 5f;
        	StartCoroutine(DestroyJustinIn(2));
		}
	}

    IEnumerator DestroyJustinIn(int seconds)
    {
        yield return new WaitForSeconds(seconds);
		Destroy(gameObject);
    }
}

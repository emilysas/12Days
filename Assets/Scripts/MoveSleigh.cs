using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSleigh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)) {
            Debug.Log("Right arrow: " + transform.position.x);
            if(transform.position.x <= Settings.RightBoundary) {
                transform.Translate(Vector3.right * Time.deltaTime * 10);
                //transform.Rotate(Vector3.left * Time.deltaTime * 15);
            }
        }
        if(Input.GetKey(KeyCode.LeftArrow)) {
            Debug.Log("Left arrow: " + transform.position.x);
            if(transform.position.x >= Settings.LeftBouundary) {
                transform.Translate(Vector3.left * Time.deltaTime * 10);
                //transform.Rotate(Vector3.right * Time.deltaTime * 15);
            }
        }
    }
}

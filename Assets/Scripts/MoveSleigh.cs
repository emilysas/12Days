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
            if(transform.position.x <= Settings.RightBoundary) {
                transform.Translate(Vector3.right * Time.deltaTime * 10);
                transform.Rotate(0,0,15 * Time.deltaTime);
            }
        }
        
        if(Input.GetKey(KeyCode.LeftArrow)) {
            if(transform.position.x >= Settings.LeftBouundary) {
                transform.Translate(Vector3.left * Time.deltaTime * 10);
                transform.Rotate(0,0,-15 * Time.deltaTime);
            }
        }
    }
}

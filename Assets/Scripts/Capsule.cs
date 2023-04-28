using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello.");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            GetComponent<Rigidbody>().AddForce(Vector3.up*5, ForceMode.VelocityChange);
            Debug.Log("Space Key Pressed");
        } 
        if (Input.GetKeyDown(KeyCode.LeftArrow)){
            GetComponent<Rigidbody>().AddForce(Vector3.left*3, ForceMode.VelocityChange);
            Debug.Log("Space Key Pressed");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)){
            GetComponent<Rigidbody>().AddForce(Vector3.right*3, ForceMode.VelocityChange);
            Debug.Log("Space Key Pressed");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnScript : MonoBehaviour {

    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.MoveRotation(Quaternion.Euler(transform.rotation.eulerAngles.x + 0.1f, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z));
        }
	}
}

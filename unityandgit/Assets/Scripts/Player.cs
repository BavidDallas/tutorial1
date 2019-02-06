using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private float inputDirection;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        inputDirection = Input.GetAxis("Horizontal");
        Debug.Log(inputDirection);
		
	}
}

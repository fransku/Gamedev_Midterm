using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class : MonoBehaviour {

	//usage: put this on a capsule with a rigidbody, mouse look and WASD movement
	public float moveSpeed;

	public float cameraSpeed;
	//this variable will remember input and pass it to physics
	Vector3 inputVector;
		
	void Update () {
		//mouse input, mouse look !
		//mouse DELTAS (different between frames
		//be 0 when mouse isnt moving, this is not moues position
		float mouseX = Input.GetAxis("Mouse X");
		float mouseY = Input.GetAxis("Mouse Y");
		
		//rotate camera based on mouse input
		transform.Rotate(0f, mouseX * cameraSpeed, 0f);
		transform.Rotate(-mouseY * cameraSpeed, 0f, 0f);
		
		//WASD MOVEMENT 
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");

		//transform.position += transform.forward * vertical * moveSpeed;
		//transform.position += transform.right * horizontal * moveSpeed; 

		inputVector = transform.forward * vertical;
		inputVector += transform.right * horizontal; 
	}

	//it runs every physics frame 
	void FixedUpdate()
	{
		GetComponent<Rigidbody>().velocity = inputVector * moveSpeed + Physics.gravity * 0.69f;
	}
}

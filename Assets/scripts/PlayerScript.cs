using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	//usage: put this on a capsule with a rigidbody, mouse look and WASD movement
	public float moveSpeed;

	public Collider PlayerIsLooking;
	
	//this variable will remember input and pass it to physics
	Vector3 inputVector;
		
	void Update () {
		Ray myRay = new Ray (Camera.main.transform.position, Camera.main.transform.forward);
		float maxRayPickUp = 10f; 
		RaycastHit myRayHit = new RaycastHit();
	
		Debug.DrawRay(myRay.origin, myRay.direction * maxRayPickUp, Color.cyan);
		
		if (Physics.Raycast(myRay, out myRayHit, maxRayPickUp))
		{
			Debug.Log("player in distance");
            //raycast is remembering what we are looking at thru playerislooking collider
			PlayerIsLooking = myRayHit.collider;
		}else
		{
            PlayerIsLooking = null; 
		}

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

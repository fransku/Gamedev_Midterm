using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidbodyVehicle : MonoBehaviour {

//intent: this is a rigidbody based player controller for a boat or car
//	usage: put this on a cube with a rigidbody

	Rigidbody rbody;
	private Vector2 inputVector;
	public float paddleForce;
	public float paddleRotation;

	void Start()
	{
		rbody = GetComponent<Rigidbody>();
	}
	
	void Update ()
	{
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");

		//inputVector = new Vector2(horizontal, vertical); 
		
		if(Input.GetKeyDown(KeyCode.A)) {
			rbody.AddForce(transform.forward * paddleForce * 1f, ForceMode.Impulse);
			rbody.AddTorque(0f, paddleRotation * 10f, 0f);

			}
		if(Input.GetKeyDown(KeyCode.D)) {
			rbody.AddForce(transform.forward * paddleForce * 1f, ForceMode.Impulse);
			rbody.AddTorque(0f, -paddleRotation * 10f, 0f);

		}

	
	}

	//fixedupdate runs every physics frame
	//to change physics framerate, go to Edit > Project settings T	
	void FixedUpdate()
	{
		
		//forward and backward thrust
		//rbody.AddForce(transform.forward * inputVector.y * 10f); 
		
		//left/right 
	//	rbody.AddTorque(0f, inputVector.x * 5f, 0f);

	}
}

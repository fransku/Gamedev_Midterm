using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastGrounded : MonoBehaviour {

	//usage: put this script on a cube
	//	
	
	// Update is called once per frame
	void Update ()
	{	 //step 1: define a Ray
		Ray myRay = new Ray(transform.position, Vector3.down);
		
		// step 2: set the raycasts maximum distance
		float maxRaycastDistance = 0.65f; 
		
		//step 3: optional- visualize the raycast
		Debug.DrawRay(myRay.origin, myRay.direction * maxRaycastDistance, Color.yellow);
		
		//step 4: actually shoot the raycast
		if (Physics.Raycast(myRay, maxRaycastDistance))
		{
			//if true, it its something
			Debug.Log("the grounded raycast hit the floor");
		}
		else
		{
			Debug.Log("not on floor");
			transform.Rotate(0, 5f, 0);
		}
	}
}

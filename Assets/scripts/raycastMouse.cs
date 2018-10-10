using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastMouse : MonoBehaviour {

	//usage: put this on your man camera (+ make sure its tagged as MainCamera
	//intent : move a sphere around based on mouse cursor raycase

	public Transform sphere; 
	
	void Update () {
		Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		float maxRayDistance = 1000f; 
		
		//step 2b: define a raycast hit variable 
		RaycastHit myRayHit = new RaycastHit();
	
		Debug.DrawRay(mouseRay.origin, mouseRay.direction * maxRayDistance, Color.cyan);

		if (Physics.Raycast(mouseRay, out myRayHit, maxRayDistance))
		{
			sphere.position = myRayHit.point;

			//wat if we wanted the tag of the thing we hit?
			Debug.Log(myRayHit.collider.tag);

			//wat if we wanted to access the object we hit
			myRayHit.transform.Rotate(0f, 0f, 1f);

			//click to draw
			if (Input.GetMouseButton(0))
			{
				//myrayhit.point is the position of the new clone
				//
				//quaternion.euler is the rotation of the new clone
				Instantiate(sphere, myRayHit.point, Quaternion.Euler(0, 0, 0));
			}
		}

	}
}

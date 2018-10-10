using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastRoomba : MonoBehaviour {

//usage: put this script on a roomba (cylinder) in a simple maze 
	//intent: let this roomba move around and navigate maze
	
	
	// Update is called once per frame
	void Update ()
	{
		Ray roombaRay = new Ray(transform.position, transform.forward);
		float maxRayDistance = 0.8f; 
		Debug.DrawRay(roombaRay.origin, roombaRay.direction * maxRayDistance, Color.cyan);
		
		if (Physics.Raycast(roombaRay, maxRayDistance))
		{
			int randomNumber = Random.Range(0, 100);
			if (randomNumber < 50)
			{
				transform.Rotate(0, -90f, 0); 
			}
			else
			{
				transform.Rotate(0, 90f, 0);
			}
		}
		else
		{
			//false, nothing in the roombas way 
			transform.Translate(0, 0, Time.deltaTime * 5f);
		}
	} 
}
		
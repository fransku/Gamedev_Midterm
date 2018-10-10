using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour {

	public float cameraSpeed;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("camera working");
		//mouse input, mouse look !
		//mouse DELTAS (different between frames
		//be 0 when mouse isnt moving, this is not moues position
		float mouseX = Input.GetAxis("Mouse X");
		float mouseY = Input.GetAxis("Mouse Y");
		
		//rotate camera based on mouse input
		transform.Rotate(0f, mouseX * cameraSpeed, 0f);
        Camera.main.transform.Rotate(-mouseY * cameraSpeed, 0f, 0f);
        //transform.Rotate(-mouseY * cameraSpeed, 0f, 0f);
    }
}

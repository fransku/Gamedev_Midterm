using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectControls : MonoBehaviour
{

	public Transform player;
	public Transform playerCam;
	public float throwForce = 1;
	 bool hasPlayer = false; 
	bool isCarried = false;
	private bool touched = false;
	
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//calculate distance between player and gameobject
		float dist = Vector3.Distance(gameObject.transform.position, player.position)
		//if distance is less than 3.5f, we can pick up object
		if (dist <= 3.5f)
		{
			hasPlayer = true;
		}
		else
		{
			hasPlayer = false; 
		}

		if (hasPlayer && Input.GetKeyDown("Space"))
		{
			GetComponent<Rigidbody>().isKinematic = true;
			transform.parent = null;
			isCarried = true; 
			
		}
		if (isCarried)
		{
			if (touched)
			{
				GetComponent<Rigidbody>().isKinematic = false;
				transform.parent = null;
				isCarried = false;
				touched = false;
			}
			if (Input.GetMouseButtonDown(0))
			{
				GetComponent<Rigidbody>().isKinematic = false;
				transform.parent = null;
				isCarried = false;
				GetComponent<Rigidbody>().AddForce(playerCam.forward * throwForce);
	}

	void OnTriggerEnter()
	{
		if (isCarried)
		{
			touched = true;
		}
	}

}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deskTrigger : MonoBehaviour {

	//put this on desk collider/trigger object, detects how many candles there are. 
	public bool gotCandle = false;
	public bool gotFire = false;

	public void OnTriggerEnter(Collider other)
	{
		if (other.tag == "candle")
		{
			gotCandle = true;
			Debug.Log("got candle");
		}
	}
}
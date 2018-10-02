using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class textScript : MonoBehaviour {

	public Text myTextDisplay; //assign in Inspector  
	public deskTrigger desk; //referencing the desk progress
	void Start ()
	{
		myTextDisplay.text = "heyo get some candles and put it on the  \nspace to grab things, click to throw";
		
	}
	
	// Update is called once per frame
	void Update () {
		if (desk.gotCandle == true)
		{
			myTextDisplay.text = "yay you win";
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class textScript : MonoBehaviour {
    //usage: i named this textScript but this has most of the game progression here. 

	public Text myTextDisplay; //assign in Inspector  
	public deskTrigger desk; //referencing the desk progress
	void Start ()
	{
		//myTextDisplay.text = "heyo get some candles and put it on the  \nspace to grab things, click to throw";
		
	}

    //seconds left to find candles
    float timeLeft = 100f; 
	void Update () {
        myTextDisplay.text = "Time left: " + (int)timeLeft;

        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            GameManager.score = 0;
            SceneManager.LoadScene("end");
        }
	}
}

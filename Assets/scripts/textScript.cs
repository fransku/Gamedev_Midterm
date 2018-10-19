using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class textScript : MonoBehaviour {
    //usage: i named this textScript but this has most of the game progression here. 

	public Text myTextDisplay; //assign in Inspector  
    public Text myTextDisplay2; //center text box
    public deskTrigger desk; //referencing the desk progress
	void Start ()
	{
		//myTextDisplay.text = "heyo get some candles and put it on the  \nspace to grab things, click to throw";
		
	}

    //seconds left to find candles
    float timeLeft = 113f; 
	void Update () {
        //first text box scene
        myTextDisplay2.text = "OH NO.. THE POWER WENT OUT!";

          if (timeLeft < 109)
            myTextDisplay2.text = "I HAVE TO WORK ON MY ART PROJECT.."; 

        if (timeLeft < 106)
           myTextDisplay2.text = "I'M SURE I HAVE SOME CANDLES LYING AROUND ";
            
        if (timeLeft < 103)
            myTextDisplay2.text = "GET THEM TO MY DESK BEFORE TIME RUNS OUT!";

        if (timeLeft < 101)
            myTextDisplay2.text = " ";
        //   Debug.Log(timeLeft);
        if ( timeLeft < 101) 
        {
            myTextDisplay.text = "TIME LEFT: " + (int)timeLeft +  "\nCANDLES COLLECTED: " + GameManager.score;
            Debug.Log("time left text should be on"); 
        }

        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            GameManager.score = 0;
            SceneManager.LoadScene("end");
        }

        //speed up playtesting
        if (Input.GetKeyDown(KeyCode.T)) 
        {
            timeLeft = 1f; 
        }
    }
}

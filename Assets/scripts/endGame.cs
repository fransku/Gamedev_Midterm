using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class endGame : MonoBehaviour {
    //usage: put on end scene empty object, attach 2 end screen buttons and make them connect to quit or try again

    public GameObject buttonOption1;
   // public GameObject buttonOption2;

    //set button text
     void Start()
    {
        if (GameManager.score == 0)
        {
            buttonOption1.gameObject.GetComponent<Text>().text = ("Try Again");
        //    buttonOption2.gameObject.GetComponent<Text>().text = ("Quit");
        }
        if (GameManager.score == 6)
        {
            buttonOption1.gameObject.GetComponent<Text>().text = ("Main Menu");
        //    buttonOption2.gameObject.GetComponent<Text>().text = ("Quit");
        }
    }

    //actually set what buttons do
    public void onClickButtonEnd()
    {
        if (GameManager.score == 0)
        {
            SceneManager.LoadScene("begin");
        }

        if (GameManager.score == 6)
        {
            SceneManager.LoadScene("begin");
            GameManager.score = 0;
        }

    }
    void Update () {
		
	}
}

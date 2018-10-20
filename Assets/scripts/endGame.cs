using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class endGame : MonoBehaviour
{
    //usage: put on end scene empty object, attach 2 end screen buttons and make them connect to quit or try again

    public Text buttonOption1;
    public Text endText; 
    // public GameObject buttonOption2;

    //set button text
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        if (GameManager.score == 0)
        {
            endText.text = "You Lose";
            buttonOption1.text = "Try Again";
            //    buttonOption2.gameObject.GetComponent<Text>().text = ("Quit");
        }
        if (GameManager.score == 6)
        {   
            endText.text = "You Win";
            buttonOption1.text = "Main Menu";
            //    buttonOption2.gameObject.GetComponent<Text>().text = ("Quit");
        }
    }

    //actually set what buttons do
    public void onClick()
    {
         
                SceneManager.LoadScene("begin");
                GameManager.score = 0;
      
    }
}


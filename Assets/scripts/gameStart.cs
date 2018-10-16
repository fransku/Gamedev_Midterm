using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameStart : MonoBehaviour {

    //public GameObject buttonOption1;

    public void onClickButtonStart()
    {
        SceneManager.LoadScene("game");
    }

    void Update () {
		
	}
}

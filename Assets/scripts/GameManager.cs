using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager manager;

    public static int score = 0;

    void Awake()
    {

        if (manager == null)
        {
            DontDestroyOnLoad(gameObject);
           // score = GameData.gameScore;
            manager = this;
        }
        else if (manager != this)
        {
            Destroy(gameObject);
        }
    }
    
}

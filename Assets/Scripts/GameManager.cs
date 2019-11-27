﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int currentScore;
    public static int highScore;

    public static int currentLevel = 0;
    public static int unlockedLevel;

    void Start()
    {
        DontDestroyOnLoad(gameObject);    
    }

    public static void CompleteLevel()
    {
        //Application.LoadLevel(currentLevel + 1);

        if(currentLevel < 2)
        {
            currentLevel += 1;
            SceneManager.LoadScene(currentLevel);
        }
        else
        {
            print("You win");
        }

        
        
        
    }
}

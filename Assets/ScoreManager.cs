﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public static int score;
    public Text scoreText;
    
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE : " + score;
    }
}

﻿using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static float score;

    Text text;
  
    void Awake()
    {
        text = GetComponent<Text>();
        score = 0;
    }


    void Update()
    {
        text.text = "Score: " + score;
    }
}


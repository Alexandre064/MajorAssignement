﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncrementScore(){
        score++;
        scoreText.text = "Score : "+score;
    }

    public void IncrementScore(int bonus)
    {
        score+=bonus;
        scoreText.text = "Score : " + score;
    }

}

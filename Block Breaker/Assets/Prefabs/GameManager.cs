﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
  public int score;
  public Text scoreText ;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = " score: " + score ;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void UpdateScore(int points){
      score += points;

      scoreText.text = "score: " + score; 
    }
}

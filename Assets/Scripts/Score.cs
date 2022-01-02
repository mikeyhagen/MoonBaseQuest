using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private void OnEnable()
    {
        GameManager.AsteroidDestroyed += DisplayScore;
    }

    private void OnDisable()
    {
        GameManager.AsteroidDestroyed -= DisplayScore;
    }

    private void DisplayScore()
    {
        Debug.Log("Score: " + GameManager.playerScore);
    }

}

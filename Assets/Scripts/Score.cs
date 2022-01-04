using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private void OnEnable()
    {
        GameManager.AsteroidDestroyed += DisplayScore;
        Debug.Log("DisplayScore added to AsteroidDestroyed Event");
    }

    private void OnDisable()
    {
        GameManager.AsteroidDestroyed -= DisplayScore;
        Debug.Log("DisplayScore removed to AsteroidDestroyed Event");
    }

    private void DisplayScore()
    {
        Debug.Log("Score: " + GameManager.playerScore);
    }

}

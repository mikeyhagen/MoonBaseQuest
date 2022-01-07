using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public enum GameState
    {
        Intro,
        Playing,
        GameOver
    }
    public static GameState eGameStatus;

    public delegate void AsteroidHandler();
    public static event AsteroidHandler AsteroidDestroyed;

    public UnityEvent onStartActivated;
    public UnityEvent onGameOver;
    public UnityEvent onGameReset;


    [Header("The Time Slider Components")]
    public Image sliderImg;
    public float gameDuration;
    private float sliderCurrentFillAmount = 1f;

    public static int playerScore = 0;

    private void Start()
    {
        eGameStatus = GameState.Intro;
    }

    private void Update()
    {
        //check if game mode is playing
        if(eGameStatus == GameState.Playing)
        {
            //adjust fill amount on timer image and update current fill amount
            sliderImg.fillAmount = (sliderCurrentFillAmount - (Time.deltaTime / gameDuration));
            sliderCurrentFillAmount = sliderImg.fillAmount;

            if(sliderCurrentFillAmount <=0)
            {
                GameOver();
            }
        }
        
    }

    private void GameOver()
    {
        eGameStatus = GameState.GameOver;
        onGameOver.Invoke();
    }

    public static void AsteroidHit()
    {
        if (eGameStatus == GameState.Playing)
        {
            playerScore += 100;
            AsteroidDestroyed();
        }
        else
        {
            Debug.Log("Not in Play mode!");
        }
        
    }

    public void StartGame()
    {
        eGameStatus = GameState.Playing;
        onStartActivated.Invoke();
    }

    public void ResetGame()
    {
        onGameReset.Invoke();

        sliderCurrentFillAmount = 1f;
        playerScore = 0;
    }

}

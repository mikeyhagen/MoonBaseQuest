using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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


    public static int playerScore = 0;

    private void Start()
    {
        eGameStatus = GameState.Intro;
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
    }

}

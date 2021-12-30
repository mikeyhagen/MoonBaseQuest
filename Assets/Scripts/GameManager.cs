using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public delegate void AsteroidHandler();
    public static event AsteroidHandler AsteroidDestroyed;


    public static int playerScore = 0;

    public static void AsteroidHit()
    {
        playerScore += 100;
        AsteroidDestroyed();
    }

}

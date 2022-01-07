using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StartButton : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("some type of collision detected");
        if (other.gameObject.CompareTag("Laser"))
        {
            //Debug.Log("START COLLISION");
            gameManager.StartGame();
        }
    }


}

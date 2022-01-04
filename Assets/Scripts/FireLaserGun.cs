using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLaserGun : MonoBehaviour
{
    public Animator gunAnimator;
    public GameObject laserBeamModel;
    public Transform laserSpawnPoint;
    public Transform laserParent;
    public void FireGun()
    {
        //Access the animator on the gun model, trigger the fire animation
        gunAnimator.SetTrigger("Fire");

        //when the trigger is pressed, play the audio.
        GetComponent<AudioSource>().Play();

        //instantiate the laser beam
        GameObject generatedLaserBeam = Instantiate(laserBeamModel,laserSpawnPoint.position,laserSpawnPoint.rotation);

        //put new laser into parent
        generatedLaserBeam.transform.SetParent(laserParent);

        //Debug.Log("Laser fire");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCollision : MonoBehaviour
{
    [SerializeField] private GameObject asteroidExplosionGO;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            Destroy(collision.gameObject);
            Instantiate(asteroidExplosionGO, collision.gameObject.transform.position, collision.transform.rotation);

            GameManager.AsteroidHit();

            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}

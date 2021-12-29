using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsMovement : MonoBehaviour
{


    public float maxSpeed;
    public float minSpeed;

    public float rotationSpeedMin;
    public float rotationSpeedMax;

    private float _rotationSpeed;
    private float xAngle, yAngle, zAngle;

    public Vector3 movementDirection;

    private float _asteroidSpeed;

    // Start is called before the first frame update
    void Start()
    {
        //get a random speed for the asteroid
        _asteroidSpeed = UnityEngine.Random.Range(minSpeed, maxSpeed);

        //get a random rotation
        xAngle = UnityEngine.Random.Range(0, 360);
        yAngle = UnityEngine.Random.Range(0, 360);
        zAngle = UnityEngine.Random.Range(0, 360);

        transform.GetChild(0).transform.Rotate(xAngle, yAngle, zAngle, Space.Self);

        _rotationSpeed = UnityEngine.Random.Range(rotationSpeedMin, rotationSpeedMax);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movementDirection * Time.deltaTime * _asteroidSpeed);
        transform.GetChild(0).transform.Rotate(Vector3.up * Time.deltaTime * _rotationSpeed);
    }
}

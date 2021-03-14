using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float timerDestroy;
    private GameObject mainCamera;

    private Rigidbody myRb;

    private Vector3 shootForce;


    private void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");

        myRb = GetComponent<Rigidbody>();

        ShootBall();

    }

    private void Update()
    {
        timerDestroy -= Time.deltaTime;

        if(timerDestroy <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void ShootBall()
    {
        myRb.AddForce(shootForce, ForceMode.Impulse);
    }

}

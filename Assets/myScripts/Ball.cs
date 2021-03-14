using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float timerDestroy;
    private GameObject mainCamera;

    private Rigidbody myRb;

    public float shootStrenght;
    public Vector3 shootForce;


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
        myRb.AddRelativeForce(Vector3.forward * shootStrenght + shootForce, ForceMode.Impulse);
    }

}

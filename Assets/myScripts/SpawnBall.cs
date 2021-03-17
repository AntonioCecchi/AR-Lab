using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject Ball;
    public GameObject CameraChild;


    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
                Instantiate(Ball, CameraChild.transform.position, CameraChild.transform.rotation);
            }
        }
    }
}

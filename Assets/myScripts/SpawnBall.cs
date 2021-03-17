using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject Ball;
    public GameObject AROrigin;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.touchCount == 1)
        {
            Instantiate(Ball, AROrigin.transform.position, Quaternion.identity);

            //spawna pallina a tot distanza dalla camera con rotazione forward;
        }
    }
}

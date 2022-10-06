using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    
    public GameObject Ball;
    public Transform SpawnPoint;
    void Start()
    {
        //SpawnBall();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            SpawnBall();

    }
    void SpawnBall()
    {
        Instantiate(Ball, SpawnPoint.position, Quaternion.identity);
    }
}


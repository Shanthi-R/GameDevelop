using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    float xInput;
    float zInput;
    public  float movespeed;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        float xVelocity = xInput * movespeed;
        float zVelocity = zInput * movespeed;
        rb.velocity = new Vector3(xVelocity, rb.velocity.y, zVelocity);


    }
}

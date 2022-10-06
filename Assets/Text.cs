using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Text : MonoBehaviour
{
    Rigidbody rb;
    
    void Start()
    {
        //Destroy(gameObject);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Destroy(gameObject);
            //rb.AddForce(Vector3.up * 500);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Level2");
        }
        

    }





    private void OnMouseDown()
    {
        // Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
       /* if (collision.gameObject.tag == "enemy")
             Destroy(gameObject);
            Destroy(collision.gameObject);*/

    }
}
    

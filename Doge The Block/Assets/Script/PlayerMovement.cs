using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float HorizontalInput;
    public float speed = 15f;
    public float xRange = 4f;
    public float health = 10;

    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.left * Time.deltaTime * speed * HorizontalInput);

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y,transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        health--;
        if(health<=0)
        {
            Destroy(gameObject);
        }
        
    }
}

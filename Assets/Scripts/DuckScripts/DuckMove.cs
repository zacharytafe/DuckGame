using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuckShoot
{
public class DuckMove : MonoBehaviour
{
    public float speed = 10;

    public bool goingRight;
    public bool goingLeft;

    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(goingRight)
        {
            // Move the object left along its z axis 1 unit/second.
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if(goingLeft)
        {
            // Move the object right along its z axis 1 unit/second.
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
}
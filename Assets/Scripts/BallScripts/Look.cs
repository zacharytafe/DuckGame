using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    public float speed = 6;

    public void Up()
    {
        transform.Rotate(Vector3.up, speed);
    }

    public void Down()
    {
        transform.Rotate(Vector3.down, speed);
    }

    public void Left()
    {
        transform.Rotate(Vector3.left, speed);
    }

    public void Right()
    {
        transform.Rotate(Vector3.right, speed);
    }
}

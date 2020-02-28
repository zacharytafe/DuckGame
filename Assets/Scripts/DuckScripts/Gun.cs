using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuckShoot
{
    public class Gun : MonoBehaviour
    {
        void Start()
        {

        }

        void Update()
        {
            faceMouse();
        }

        void faceMouse()
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            Vector3 direction = new Vector3(
                    mousePosition.x - transform.position.x,
                    mousePosition.y - transform.position.y,                   
                    mousePosition.z - transform.position.z                   
                );
            transform.forward = direction;
        }
    }
}
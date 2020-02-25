using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuckShoot
{
    public class BombFall : MonoBehaviour
    {
        public float bombSpeed = 10;

        void Awake()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(Vector3.back * bombSpeed * Time.deltaTime);
        }
    }
}
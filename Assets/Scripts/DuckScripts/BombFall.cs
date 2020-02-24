using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuckShoot
{
    public class BombFall : MonoBehaviour
    {
        public float bombSpeed = 10;

        // Start is called before the first frame update
        void Awake()
        {
            transform.Translate(Vector3.forward * bombSpeed * Time.deltaTime);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
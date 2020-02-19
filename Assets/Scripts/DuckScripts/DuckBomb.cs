using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuckShoot
{
    public class DuckBomb : MonoBehaviour
    {
        public GameObject bomb;
        public float pawnRate = 1;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == "BombPoint")
            {
                for (int i = 0; i < 1; i++)
                {
                    Instantiate(bomb, new Vector3(i * 0, 0, 0), Quaternion.identity);
                }
            }
        }
    }
}
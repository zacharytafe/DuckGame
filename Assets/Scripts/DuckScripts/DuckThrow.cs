using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuckShoot
{
    public class DuckThrow : MonoBehaviour
    {
        public Rigidbody projectile;
        public Transform throwArea;

        public float startSpawn;
        public float spawnRate;

        // Start is called before the first frame update
        void Start()
        {
            InvokeRepeating("Throw", startSpawn, spawnRate);
        }

        // Update is called once per frame
        void Update()
        {

        }

        void Throw()
        {
            Rigidbody bombInstance;
            bombInstance = Instantiate(projectile, throwArea.position, throwArea.rotation) as Rigidbody;
            bombInstance.AddForce(throwArea.up * 500f);
        }
    }
}
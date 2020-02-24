﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuckShoot
{
    public class DuckBomb : MonoBehaviour
    {
        public Rigidbody bomb;
        public Transform bombBay;

        public float startSpawn;
        public float spawnRate;

        // Start is called before the first frame update
        void Start()
        {
            InvokeRepeating("Loose", startSpawn, spawnRate);
        }

        void Update()
        {
                           
        }

        void Loose()
        {
            Rigidbody bombInstance;
            bombInstance = Instantiate(bomb, bombBay.position, bombBay.rotation) as Rigidbody;
            //bombInstance.AddForce(bombBay.down * 20f);
        }
    }
}
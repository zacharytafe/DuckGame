﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBoat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Iceberg")
        {
            Destroy(gameObject);
        }
    }
}

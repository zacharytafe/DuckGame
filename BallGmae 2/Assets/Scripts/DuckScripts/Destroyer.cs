﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    { 
        if(col.gameObject.name == "Destroyer")
        {
            Destroy(gameObject);
        }
    }
}

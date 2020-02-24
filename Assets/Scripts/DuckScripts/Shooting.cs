using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuckShoot
{
public class Shooting : MonoBehaviour
{
    public float damage = 10;
    public float range = 1000f;

    public Camera fpsCam;
    public GameObject impactEffect;
    public AudioSource gunBang;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
            //Debug.Log("Press Space Bar");
            gunBang.Play();
        }
    }

    void Fire()
    {
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            // Debug.Log(hit.transform.name);
            Target duck = hit.transform.GetComponent<Target>();
            if (duck != null)
            {
                duck.TakeDamage(damage);
            }

            GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO, 2f);           
        }
    }
}
}
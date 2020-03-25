using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

namespace DuckShoot
{
public class Shooting : MonoBehaviour
{
    public float damage = 10;
    public float range = 1000f;
    public float score;

    public Camera fpsCam;
    public GameObject impactEffect;
    public AudioSource gunBang;
    public Text scoreCount;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Fire();
            //Debug.Log("Press Space Bar");
            gunBang.Play();
        }
    }

    void Fire()
    {
        RaycastHit hit;
            Ray ray = fpsCam.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit, range))
        {
            // Debug.Log(hit.transform.name);
            Target duck = hit.transform.GetComponent<Target>();
            if (duck != null)
            {
                duck.TakeDamage(damage);
            }

            if(hit.transform.tag == "YellowDuck")
            {
                score += 5;
                scoreCount.text = score.ToString();
            }

            if (hit.transform.tag == "GreenDuck")
            {
                score += 5;
                scoreCount.text = score.ToString();
            }

            if (hit.transform.tag == "ME109Duck")
            {
                score += 19;
                scoreCount.text = score.ToString();
            }

            if (hit.transform.tag == "Projectile")
            {
                score += 1;
                scoreCount.text = score.ToString();
            }

            if (hit.transform.tag == "Frigate")
            {
                score += 1;
                scoreCount.text = score.ToString();
            }

                GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO, 2f);           
        }
    }

}
}
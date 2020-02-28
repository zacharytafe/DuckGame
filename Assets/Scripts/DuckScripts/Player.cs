using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DuckShoot
{
    public class Player : MonoBehaviour
    {
        private float startHealth = 100;
        public float currentHealth;
        public float damageTake = 10;

        public Text healthCount;
        public GameObject deathTest;



        // Start is called before the first frame update
        void Start()
        {
            currentHealth = startHealth;
            healthCount.text = currentHealth.ToString();            
        }

        // Update is called once per frame
        void Update()
        {          
            if(currentHealth <= 0)
            {
                Death();
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.tag == "Projectile")
            {
                currentHealth -= damageTake;
                healthCount.text = currentHealth.ToString();
                Destroy(collision.gameObject);
            }
            
        }

        void Death()
        {
            Time.timeScale = 0;
            deathTest.SetActive(true);
        }
    }
}
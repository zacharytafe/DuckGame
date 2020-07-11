using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DuckShoot
{
    public class Player : MonoBehaviour
    {
        private float startHealth = 500;
        public float currentHealth;
        public float damageTake = 10;

        public Text healthCount;
        public GameObject deathTest;
        public GameObject hurtScreen;


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
                StartCoroutine(Hurt());
            }
            
        }

        void Death()
        {
            Time.timeScale = 0;
            deathTest.SetActive(true);
        }

        IEnumerator Hurt()
        {
            
            hurtScreen.SetActive(true);
            yield return new WaitForSeconds(1);
            hurtScreen.SetActive(false);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DuckShoot
{
    public class Target : MonoBehaviour
    {
        public float health;
        public float pointsValue = 10;


        // Start is called before the first frame update
        void Start()
        {

        }

        void Update()
        {

        }

        public void TakeDamage (float amount)
        {
            health -= amount;
            if (health <= 0f)
            {
                KnockedOver();
            }
        }

        public void KnockedOver()
        {
            Destroy(gameObject);
        }

        
    }
}

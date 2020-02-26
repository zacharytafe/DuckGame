using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DuckShoot
{
    public class Target : MonoBehaviour
    {
        public float health;

        // Start is called before the first frame update
        void Start()
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

        void KnockedOver()
        {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DuckShoot
{
    public class Target : MonoBehaviour
    {
        public float health;
        public float pointsValue;
        public float score;

        public Text scoreCount;


        //public GameObject gameSystem;

        // Start is called before the first frame update
        void Start()
        {

        }

        public void TakeDamage (float amount)
        {
            health -= amount;
            if (health <= 0f)
            {
                // gameSystem.GetComponent<ScoreSystem>().AddPoints();
                //AddPoints();
                KnockedOver();
            }
        }

        public void KnockedOver()
        {
            Destroy(gameObject);
        }

        public void AddPoints()
        {
            score += 1;
            scoreCount.text = score.ToString();
        }
    }
}

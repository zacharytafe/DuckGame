using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BallGame
{
    public class Goal : MonoBehaviour
    {
        public int scoreValue;

        public static int score;
        public Text scoreCount;
        public Text finScore;

        public void Start()
        {
            //scoreCount = GetComponent<Text>();
            score = 0;
        }

        public void Update()
        {
            scoreCount.text = score + ("");
            finScore.text = score + ("");
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Ball")
            {
                score += scoreValue;
            }
        }
    }
}
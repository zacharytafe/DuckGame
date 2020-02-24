using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DuckShoot
{
    public class ScorePoints : MonoBehaviour
    {
        public float startSore = 0;
        public float currentScore;
        public float pointsValue;

        public Text scoreCount;

        // Start is called before the first frame update
        void Start()
        {
            currentScore = startSore;
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.M))
            {
                AddScore();
            }
        }

        void AddScore()
        {
            currentScore += 1;
            scoreCount.text = currentScore.ToString();
        }
    }
}
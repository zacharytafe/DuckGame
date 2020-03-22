using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public float score;
    public Text scoreCount;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoints()
    {
        score += 1;
        scoreCount.text = score.ToString();
    }
}

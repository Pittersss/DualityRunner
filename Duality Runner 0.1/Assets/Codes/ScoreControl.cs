using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;
    public float scoreCount;
    static float hiScoreCount;
    public float pointsPerSecounds;
    public bool scoreIncris;
    void Update()
    {
        if(scoreIncris)
        {
            scoreCount += pointsPerSecounds * Time.deltaTime;
        }
        if(scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
        }
        
        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        highScoreText.text = " " + Mathf.Round(hiScoreCount);
    }
}

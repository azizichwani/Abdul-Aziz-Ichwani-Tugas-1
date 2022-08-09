using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    private int scoreValue;

    // Start is called before the first frame update
    void Start()
    {
        scoreValue = 0;
        ScoreText.text = "Score : " + scoreValue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore()
    {
        scoreValue += 20;
        ScoreText.text = "Score : " + scoreValue;
    }
}

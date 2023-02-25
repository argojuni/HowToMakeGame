using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text highScoreText;
    public static string highScore;
    public static string scoreHigh;

    // Update is called once per frame
    void Start()
    {
        highScoreText.text = PlayerPrefs.GetFloat("HighScore").ToString();    
    }
    void Update()
    {
        float number = (int)player.position.z;
        scoreText.text = number.ToString("0");
        highScore = scoreText.text;
        if(number > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", number);
            highScoreText.text = number.ToString("0");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public string scoreHigh;

    void Start()
    {
        HighScoreText();    
    }
    public void BackStart()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Quit()
    {
        Application.Quit();
    }

    void HighScoreText()
    {
        scoreHigh = Score.highScore;
        Debug.Log(scoreHigh);
    }
}

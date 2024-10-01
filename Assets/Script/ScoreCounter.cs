using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    int score;

    [SerializeField]
    TMPro.TextMeshProUGUI ScoreText;
    void Start()
    {
        score = 0;
    }
    public void AddScore()
    {
        ++score;

        ScoreText.SetText("SCORE {0}/10", score);

        if (score >= 10)
        {
            ShowGameCrerScreen();
        }
    }
    public void ShowGameCrerScreen()
    {
        SceneManager.LoadScene("GameClear");
    }
    void Update()
    {
        
    }
}
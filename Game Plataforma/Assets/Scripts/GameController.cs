using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text healthText;

    public int score;
    public Text scoreText;

    public int totalScore;

    public static GameController instance;


    // Awake é inicializado antes de todos os métodos start() do seu projeto
    void Awake()
    {
        instance = this;

    }

    void Start()
    {
        totalScore = PlayerPrefs.GetInt("score");    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int value)
    {
        score += value;
        scoreText.text = score.ToString();
        PlayerPrefs.SetInt("score", score + totalScore);
    }

    public void UpdateLives(int value)
    {
        healthText.text = "x " + value.ToString();
    }
}

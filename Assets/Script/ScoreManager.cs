using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;

    public void AddScore(int points)
    {
        score += points;
        Debug.Log("Puntaje actual: " + score);
        scoreText.text = "Puntaje actual: " + score;
    }
}
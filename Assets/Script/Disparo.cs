using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public int score = 0;
    public ScoreManager scoreManager;

    private void OnMouseDown()
    {
        if (gameObject.CompareTag("Objetivo1"))
        {
            score = 100;
            scoreManager.AddScore(score);
        }
        if (gameObject.CompareTag("Objetivo2"))
        {
            score = 50;
            scoreManager.AddScore(score);
        }
        if (gameObject.CompareTag("Objetivo3"))
        {
            score = 25;
            scoreManager.AddScore(score);
        }
        if (gameObject.CompareTag("Objetivo4"))
        {
            score = 10;
            scoreManager.AddScore(score);
        }
    }
}

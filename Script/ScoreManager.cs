using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0; // Ba�lang�� puan�
    public TMP_Text scoreText; // Puan� g�steren UI text

    private void Start()
    {
        UpdateScore(); // Ba�lang��ta puan� UI'da g�ster
    }

    public void AddScore(int amount)
    {
        score += amount; // Puan� artt�r
        UpdateScore(); // Puan� UI'da g�ncelle
    }

    private void UpdateScore()
    {
        scoreText.text = "Score: " + score; // Puan� UI'da g�ster
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0; // Baþlangýç puaný
    public TMP_Text scoreText; // Puaný gösteren UI text

    private void Start()
    {
        UpdateScore(); // Baþlangýçta puaný UI'da göster
    }

    public void AddScore(int amount)
    {
        score += amount; // Puaný arttýr
        UpdateScore(); // Puaný UI'da güncelle
    }

    private void UpdateScore()
    {
        scoreText.text = "Score: " + score; // Puaný UI'da göster
    }
}

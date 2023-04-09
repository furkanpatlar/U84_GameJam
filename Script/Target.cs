using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Target : MonoBehaviour
{
    public int scoreValue = 10; // Hedefe �arp�nca kazan�lacak puan
    public TMP_Text scoreText; // Puan� g�steren UI text

    private int score = 0; // Ba�lang�� puan�

    private void Start()
    {
        UpdateScore(); // Ba�lang��ta puan� UI'da g�ster
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("hedef"))
        {
            score += scoreValue; // Puan� artt�r
            Destroy(other.gameObject); // Hedefi yok et
            UpdateScore(); // Puan� UI'da g�ncelle

        }
    }

    private void UpdateScore()
    {
        scoreText.text = "Score: " + score; // Puan� UI'da g�ster
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Target : MonoBehaviour
{
    public int scoreValue = 10; // Hedefe çarpýnca kazanýlacak puan
    public TMP_Text scoreText; // Puaný gösteren UI text

    private int score = 0; // Baþlangýç puaný

    private void Start()
    {
        UpdateScore(); // Baþlangýçta puaný UI'da göster
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("hedef"))
        {
            score += scoreValue; // Puaný arttýr
            Destroy(other.gameObject); // Hedefi yok et
            UpdateScore(); // Puaný UI'da güncelle

        }
    }

    private void UpdateScore()
    {
        scoreText.text = "Score: " + score; // Puaný UI'da göster
    }
}

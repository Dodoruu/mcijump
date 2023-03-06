using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public GameObject player; // Referenz auf das Player-GameObject
    public TextMeshProUGUI scoreText; // Referenz auf das TextMeshPro-Objekt, das den Score anzeigen soll

    private int highScore = 0; // Variable, die den h�chsten erreichten Score speichert

    void Update()
    {
        int currentScore = (int)player.transform.position.y; // Aktuellen Score auslesen und in ein int konvertieren

        if (currentScore > highScore) // Wenn der aktuelle Score h�her ist als der h�chste erreichte Score
        {
            highScore = currentScore; // Den h�chsten erreichten Score aktualisieren
        }

        scoreText.text = " " + highScore.ToString(); // Den h�chsten erreichten Score in TextMeshPro-Fenster eingeben
    }
}

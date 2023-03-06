using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public GameObject player; // Referenz auf das Player-GameObject
    public TextMeshProUGUI scoreText; // Referenz auf das TextMeshPro-Objekt, das den Score anzeigen soll

    private int highScore = 0; // Variable, die den höchsten erreichten Score speichert

    void Update()
    {
        int currentScore = (int)player.transform.position.y; // Aktuellen Score auslesen und in ein int konvertieren

        if (currentScore > highScore) // Wenn der aktuelle Score höher ist als der höchste erreichte Score
        {
            highScore = currentScore; // Den höchsten erreichten Score aktualisieren
        }

        scoreText.text = " " + highScore.ToString(); // Den höchsten erreichten Score in TextMeshPro-Fenster eingeben
    }
}

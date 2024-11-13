using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public bool isGameOver;
    private float score = 0;
    private bool isPlayerDead = false;

    public void StopScore()
    {
        isPlayerDead = true;
    }

    private void OnEnable()
    {
        PlayerHealth.OnPlayerDeath += StopScore;
    }

    private void OnDisable()
    {
        PlayerHealth.OnPlayerDeath -= StopScore;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerDead == false)
        {
            score += Time.deltaTime * 1.764f;
        }
        scoreText.text = "Distance: " + score.ToString("F1") + "m";
    }
}

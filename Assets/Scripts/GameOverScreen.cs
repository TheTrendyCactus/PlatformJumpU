using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    public GameObject gameOverMenu;


    public void EnableGameOverMenu()
    {
        gameOverMenu.SetActive(true);
    }
    private void OnEnable()
    {
        PlayerHealth.OnPlayerDeath += EnableGameOverMenu;
    }

    private void OnDisable()
    {
        PlayerHealth.OnPlayerDeath -= EnableGameOverMenu;
    }

}
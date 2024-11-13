using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static event Action OnPlayerDeath;
    public float health, maxHealth;

    private void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        { 
            //Display game over screen
            health = 0;
            Debug.Log("I am Dead!!");
            OnPlayerDeath?.Invoke();
    }
    }
}

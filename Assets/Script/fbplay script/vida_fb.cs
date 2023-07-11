using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vida_fb : MonoBehaviour
{
    public float maxVida = 100f;  
    public Image life;  

    private float currentHealth;  

    // Inicialización
    private void Start()
    {
        currentHealth = maxVida;
        UpdateHealthBar();
    }

   
    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        UpdateHealthBar();

        if (currentHealth <= 0)
        {
            
            Debug.Log("El jugador ha muerto."); //mensaje de consola
        }
    }

   
    private void UpdateHealthBar()
    {
        life.fillAmount = currentHealth / maxVida;
    }




}

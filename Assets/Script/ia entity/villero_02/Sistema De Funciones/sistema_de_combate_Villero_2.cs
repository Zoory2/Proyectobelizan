using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sistema_de_combate_Villero_1 : MonoBehaviour
{
    public float nivel_de_daño = 10f; 
    public vida_fb fb;  

    
    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.CompareTag("Player"))
        {
            
            fb.TakeDamage(nivel_de_daño);
        }
    }
}


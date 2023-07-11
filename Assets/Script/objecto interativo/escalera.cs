using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escalera : MonoBehaviour
{
   
    [SerializeField] private float velocidadEscalera = 9f;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            float movimientoVertical = Input.GetAxis("Vertical");
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = new Vector2(rb.velocity.x, movimientoVertical * velocidadEscalera);
            }
        }
    }
}





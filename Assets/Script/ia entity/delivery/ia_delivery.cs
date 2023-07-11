using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ia_delivery : MonoBehaviour
{
    public float speed = 0.36f;
    public float moveDistance = 0.41f;
    private bool movingRight = true;

    private Vector2 startPos;
    private Animator At;

    void Start()
    {
        At = GetComponent<Animator>();
        
        // Guarda la posición inicial del enemigo
        startPos = transform.position;
    }

    void Update()
    {
        if (movingRight)
        {
            // Mueve al enemigo hacia la derecha
            transform.Translate(Vector2.right * speed * Time.deltaTime);

            // Si alcanza la distancia máxima hacia la derecha, cambia la dirección
            if (transform.position.x >= startPos.x + moveDistance)
            {
                At.SetFloat("Caminar3", moveDistance);
                GetComponent<SpriteRenderer>().flipX = true;
                movingRight = false;
            }
        }
        else
        {
            // Mueve al enemigo hacia la izquierda
            transform.Translate(Vector2.left * speed * Time.deltaTime);

            // Si alcanza la distancia máxima hacia la izquierda, cambia la dirección
            if (transform.position.x <= startPos.x - moveDistance)
            {
                GetComponent<SpriteRenderer>().flipX = false;
                At.SetFloat("Caminar3", moveDistance);
                movingRight = true;
            }
        }
    }
}

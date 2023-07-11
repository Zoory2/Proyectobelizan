using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ia_villero_02 : MonoBehaviour
{
    public float speed = 0.36f;
    public float moveDistance = 0.68f;
    private bool movingRight = true;

    private Vector2 startPos;
    private Animator Ani;
    void Start()
    {
        Ani = GetComponent<Animator>();
        
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
                GetComponent<SpriteRenderer>().flipX = true;
                movingRight = false;
                Ani.SetFloat("Caminar2", moveDistance);

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
                movingRight = true;
                Ani.SetFloat("Caminar2", moveDistance);
            }
        }
    }

}


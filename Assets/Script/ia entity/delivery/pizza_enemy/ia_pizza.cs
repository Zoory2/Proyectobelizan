using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ia_pizza : MonoBehaviour
{
    public float velocidad;
    public float Distancia;
    public float retreatDistance;

    private Transform playercontrol;

    void Start()
    {
        playercontrol = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, playercontrol.position) > Distancia)
        {

            transform.position = Vector2.MoveTowards(transform.position, playercontrol.position, velocidad * Time.deltaTime);
        }
        else if (Vector2.Distance(transform.position, playercontrol.position) < Distancia && Vector2.Distance(transform.position, playercontrol.position) > retreatDistance)
        {

            transform.position = this.transform.position;
        }
        else if (Vector2.Distance(transform.position, playercontrol.position) < retreatDistance)
        {

            transform.position = Vector2.MoveTowards(transform.position, playercontrol.position, -velocidad * Time.deltaTime);
        }




        if (Vector2.Distance(transform.position, playercontrol.position) > Distancia)
        {
            GetComponent<SpriteRenderer>().flipX = true;

        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }


        if (Vector2.Distance(transform.position, playercontrol.position) < Distancia)
        {
            GetComponent<SpriteRenderer>().flipX = true;

        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }





    }
}

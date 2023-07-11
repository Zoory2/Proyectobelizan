using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playercontrol: MonoBehaviour
{
    public float velocidad = 6f;
    public float salto = 3f;
    
    private Rigidbody2D rb2d;
    private Animator anim;  

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();    
    
    }

    void Update()
    {
        //movimiento
        var movimientoX = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movimientoX, 0, 0) * Time.deltaTime * velocidad;

        //animaciones
        anim.SetFloat("Correr",Mathf.Abs(movimientoX));


        
        //salto
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb2d.velocity.y) < 0.1f)
        {
            rb2d.AddForce(new Vector2(0, salto), ForceMode2D.Impulse);
        
        
        }




        //flip y,x
        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<SpriteRenderer>().flipX = true;
            

        }
  
        if (Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<SpriteRenderer>().flipX = false;

        }
        //flip_left_right(creo que no es la forma correcta YA, FUEE)
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GetComponent<SpriteRenderer>().flipX = true;

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<SpriteRenderer>().flipX = false;

        }




        //banana
        if (Input.GetKeyDown(KeyCode.C)) { 
        
        
        
        }

    }

    
    






}



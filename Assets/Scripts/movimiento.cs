using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    private Rigidbody2D Rigidbody2D;
    private float Horizontal;
    public float Speed;
    public float JumpForce;
    private bool Grounded; //Para que no vuele, true=suelo, false=aire
    private void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame (El update se ejeecuta 60fps por ejemplo (60 veces))
    private void Update()
    {
        // Movimiento
        Horizontal = Input.GetAxisRaw("Horizontal");
        if (Horizontal < 0.0f) transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);       //Para controlar la dirección (-1 Izquierda, 1 Derecha)
        else if (Horizontal > 0.0f) transform.localScale = new Vector3 (1.0f, 1.0f, 1.0f);

        //Espacio para saltar
        if (Input.GetKeyDown(KeyCode.Space))    
        {
            Jump();
        }
    }
    private void FixedUpdate()
    {
        Rigidbody2D.velocity = new Vector2(Horizontal * Speed, Rigidbody2D.velocity.y); //Vector2 para movernos en x e y
    }

    //Salto
    private void Jump()
    {
        Rigidbody2D.AddForce(Vector2.up * JumpForce); //Para regular la fuerza del salto
    }
}

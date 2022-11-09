using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocity = 1;
    private Rigidbody2D rb;
    public ControladorEscena controladorEscena;
     void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
     void Update()
    {
        if (Input.GetMouseButtonDown(0))
        //if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        controladorEscena.Perdiste();
    }

}

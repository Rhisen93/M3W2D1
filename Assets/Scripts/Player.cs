using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float Speed;
    Rigidbody2D _rb;
    private bool Jump;



    // Start
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        Jump = Input.GetButtonDown("Jump");

    }

    // Update
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");
        //Vector2 nv = (new Vector2(h, 0)).normalized;

        _rb.velocity = new Vector2(h * Speed, _rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("O mio dio sta saltando!");
            _rb.AddForce(Vector2.up * Speed, ForceMode2D.Impulse);

            //Jump = true;
        }

    }

    // Fixed
    void FixedUpdate()
    {

        

    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
        
        // Limite de jugador en patalla
        if (transform.position.x > 8.8f) // Borde Derecha
        {
            transform.position = new Vector3(8.8f, transform.position.y, 0);
        }
        else if (transform.position.x < -8.78) // Borde Izquierda
        {
            transform.position = new Vector3(-8.78f, transform.position.y, 0);
        }

    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        }
    }
    
}

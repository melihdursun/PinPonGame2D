using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombayoket : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
  

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
        Destroy(gameObject, 2f);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "top") 
        {
           
            Destroy(gameObject);

        }
    }

}

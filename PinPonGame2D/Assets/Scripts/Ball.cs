using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    Rigidbody2D rb2;
    public float moveSpeed = 10;
    public Topatar kullanıcı;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("baslangichareket", 2);
   
    }


    private void baslangichareket()
    {
        rb2 = GetComponent<Rigidbody2D>();
        rb2.velocity = new Vector2(1, 0) * moveSpeed;
    }


    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        TagManager tagManager = collision.gameObject.GetComponent<TagManager>();

        GetComponent<AudioSource>().Play();
        if (collision.gameObject.tag.Equals("gulle"))
        {
            kullanıcı.SkorYap();
        }

    }
}

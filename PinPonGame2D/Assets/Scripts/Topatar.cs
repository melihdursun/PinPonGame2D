using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Topatar : MonoBehaviour
{
   
    public Rigidbody2D bombPrefab;
    public Transform bombSpawn;
    public float bombSpeed=10f;

    public int Score { get; private set; }
    public Text ScoreText;
    public int YüksekSkor;

    public void SkorYap()
    {
        Score++;
        ScoreText.text = Score.ToString();
        if (Score % 40 == 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 8);
        }

        if (Score > YüksekSkor)
        {
            YüksekSkor = Score;
        }
        if (Score % 5 == 0)
        {
            TopAtarrYükselt();
        }
    }

    public void TopAtarrYükselt()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 1);
    }

    string axisName = "Horizontal1";
    public float moveSpeed=10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveAxis = Input.GetAxis(axisName) * moveSpeed;

        GetComponent<Rigidbody2D>().velocity = new Vector2(moveAxis, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ateset(); //ateş ediliyor
            
        }
        
    }


    private void ateset()
    {
        var bomb = Instantiate(bombPrefab, bombSpawn.position, bombSpawn.rotation);
        
    }


}

    

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed = 100f;
    public Rigidbody2D rb;
  
  
    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D collision)
    {

       
        Destroy(gameObject);
        

    }
}
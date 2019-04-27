using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public int health = 5;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        var mov = new Vector3(moveHorizontal, moveVertical, 0);
        var rb = GetComponent<Rigidbody2D>();
        rb.velocity = mov * speed;
    }

    void GetDamage() {
        health--;
        if (health<=0) {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Meteor")
        {
            
            GetDamage();
        }
        if (collision.gameObject.tag == "EnemBullet") {
            GetDamage();
        }



    }
}

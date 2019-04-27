using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorito : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed=-0.02f;

    public int healthM = 5;
   

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(new Vector3(speed, 0, 0));


    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Bullet") {
            Debug.Log("disparo");
            DamageMeteorito();
        }

       


    }

    void DamageMeteorito() {
        healthM--;
        if (healthM <= 0)
        {
            Destroy(gameObject);
        }

    }
}

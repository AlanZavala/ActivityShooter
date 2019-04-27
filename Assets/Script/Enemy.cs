using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed = -0.02f;
    public Transform bulletPrefab;
    public Transform position;
    private int healthE = 3;
    private float timeFire =1.5f;
    private float timeDestroy= 4.5f;
    // Start is called before the first frame update


    void Start()
    {
        StartCoroutine(Shoot());
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(new Vector3(speed, 0, 0));

    }
    IEnumerator Shoot()
    {
            //Debug.Log("fireball");
            yield return new WaitForSeconds(timeFire);
            Transform cannonb = Instantiate(bulletPrefab, position.transform.position, position.transform.rotation);

            Destroy(cannonb.gameObject, timeDestroy);

            StartCoroutine(Shoot());


    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log("disparo");
            DamageEnemy();
        }




    }

    void DamageEnemy()
    {
        healthE--;
        if (healthE <= 0)
        {
            Destroy(gameObject);
        }

    }


}

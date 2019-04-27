using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemWeapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    float timer;





    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1.5f)
        {
            Shoot();
        }



    }
    void Shoot()
    {

        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);


    }
}


//IEnumerator Shoot()
//{
//    if (inside)
//    {
//        //Debug.Log("fireball");
//        yield return new WaitForSeconds(timeFire);
//        Transform cannonb = Instantiate(cannonBall, position.transform.position, position.transform.rotation);
//        Destroy(cannonb.gameObject, timeDestroy);
//        StartCoroutine(Shoot());
//    }

//}
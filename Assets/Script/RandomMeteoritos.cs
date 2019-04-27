using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMeteoritos : MonoBehaviour
{
    float timer;
    public GameObject meteorPreb;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 3f)
        {
            float ranPos = Random.Range(-3f, 3f);
            Vector3 pos = new Vector3(9, ranPos, 0);
            timer = 0;
            Instantiate(meteorPreb, pos, Quaternion.identity);
        }
    }
}

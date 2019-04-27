using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemies : MonoBehaviour
{
    // Start is called before the first frame update
    float timer;
    public GameObject enemyPreb;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 3f)
        {
            float ranPos = Random.Range(-3f, 3f);
            Vector3 pos = new Vector3(9, ranPos, 0);
            timer = 0;
            Instantiate(enemyPreb, pos, Quaternion.identity);
        }
    }
}

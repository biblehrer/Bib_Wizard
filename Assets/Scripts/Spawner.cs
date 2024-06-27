using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public float timer = 3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            GameObject toSpawn = enemyPrefab[Random.Range(0,3)];
            Vector3 position = new Vector3(Random.Range(-5f,5f), Random.Range(-5f,5f),0);
            Instantiate(toSpawn, position, Quaternion.identity);
            timer = 3;
        }
    }   
}

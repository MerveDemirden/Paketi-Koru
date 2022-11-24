using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngelDogmasi : MonoBehaviour
{
    public GameObject engel;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float dogmazamani;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > dogmazamani)
        {
            dogma();
            dogmazamani = Time.time + timeBetweenSpawn;
        }

    }
    void dogma()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(engel, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }

}

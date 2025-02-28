using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float timeToSpawn, minXPos, maxXPos;
    private float timer;

    private void Start()
    {
        timer = timeToSpawn;
    }

    private void Update()
    {
        if (timer <= 0)
        {
            timer = timeToSpawn;
            GameObject pipe = Instantiate(pipePrefab, transform.position, Quaternion.identity);
            float rand = Random.Range(minXPos, maxXPos);
            pipe.transform.position = new Vector2(rand, pipe.transform.position.y);
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}

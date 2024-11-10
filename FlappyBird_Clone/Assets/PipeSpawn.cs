using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer1 = 0;
    public float height = 2;
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer1 < spawnRate) {
            timer1 = timer1 + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer1 = 0;
        }

    }
    
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - height;
        float highestPoint = transform.position.y + height;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), transform.position.z), transform.rotation);
    }
}

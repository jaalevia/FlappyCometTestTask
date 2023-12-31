using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float[] queueTime = new float[] {1.5f, 3, 5 };
    
    private float time = 0;
    public GameObject[] obstacle = new GameObject[2];

    public float height;
    float a;

    private void Start()
    {
        a = queueTime[Random.Range(0, queueTime.Length)];
    }
    void Update()
    {
       
        if (time > a)
        {
            a = queueTime[Random.Range(0, queueTime.Length)];
            GameObject go = Instantiate(obstacle[Random.Range(0, obstacle.Length)]);
            go.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

            time = 0;

            Destroy(go, 10);
            
        }
        time += Time.deltaTime;

    }

}

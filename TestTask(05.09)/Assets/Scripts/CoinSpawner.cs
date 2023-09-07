using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    private float[] queueTime = new float[] {1, 3, 6, 9};

    private float time = 0;
    public GameObject obstacle;

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
            GameObject go = Instantiate(obstacle);
            go.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

            time = 0;

            Destroy(go, 20);

        }
        time += Time.deltaTime;

    }
}

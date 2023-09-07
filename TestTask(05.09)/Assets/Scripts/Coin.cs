using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    public float speed;


    void Update()
    {
        Vector3 newpos = transform.position += ((Vector3.left * speed) * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocity = 2.4f;
    private new Rigidbody2D rigidbody;
    private int addrig = 0;
    private int spac = 0;
    public GameObject Coin;
    public GameObject Enemy;
    public GameObject Txt;
    void Update()
    {
        if (addrig > 0)
        {
            if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.Space))
            {
                rigidbody.velocity = Vector2.up * velocity;
            }
        }
        if (Input.GetKey(KeyCode.Space) && spac == 0)
        {
            AddRigid();
            spac += 1;
        }
    }

    public void AddRigid()
    {
            addrig += 1;
            gameObject.AddComponent<Rigidbody2D>();
            rigidbody = GetComponent<Rigidbody2D>();

        Coin.SetActive(true);
        Enemy.SetActive(true);
        Txt.SetActive(false);
    }   
}

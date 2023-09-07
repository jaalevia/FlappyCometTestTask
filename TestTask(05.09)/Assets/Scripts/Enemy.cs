using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float UpDownValue;
    public int a = 0;
    public int b = 0;
    void Update()
    {  
        
       float upside = Mathf.PingPong(Time.time * UpDownValue, 1) * a - b;
       
       Vector3 newpos = transform.position += ((Vector3.left * speed) * Time.deltaTime);
       
       transform.position = new Vector3(newpos.x, upside, 0);
        
    }

}

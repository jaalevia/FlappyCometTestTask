using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    int score = 0;
    private void Start()
    {
        textMeshPro.text = score.ToString();
    }
    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
        if (collision2D.gameObject.tag == "Coin")
        {
            score += 1;
            textMeshPro.text = score.ToString();
        }

    }
}

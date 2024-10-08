using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtBoss : MonoBehaviour
{
    private int damage = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Boss"))
        {
            collision.gameObject.GetComponent<BossHealth>().GetHurt(damage);
        }
    }
}

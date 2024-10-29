using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermyMovement : MonoBehaviour
{
    public EnemyScriptableObject enemyData;

    public PlayerHealth playerHealth;

    public float damageInterval = 1f;
    private float lastDamageTime;

    Transform player;

    void Start()
    {
        player = FindObjectOfType<PlayerMovement>().transform;
        lastDamageTime = Time.time;
    }


    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, enemyData.MoveSpeed * Time.deltaTime);
        
    }

    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(1);
        }

        
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && Time.time - lastDamageTime >= damageInterval)
        {
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(1);
                lastDamageTime = Time.time;
            }
        }
    }



}

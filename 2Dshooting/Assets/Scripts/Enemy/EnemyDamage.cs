using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    
    public PlayerHealth playerHealth;
    
    
   private void OnCollisionEnter2D(Collision2D collision)
{
    Debug.Log("Collision Detected with: " + collision.gameObject.name);
    if (collision.gameObject.tag == "Player")
    {
        Debug.Log("Collision with Player confirmed");
        if (playerHealth != null) {
            playerHealth.TakeDamage(1);
            Debug.Log("Damage applied, current health: " + playerHealth.health);
        } else {
            Debug.LogError("PlayerHealth reference not set in the inspector.");
        }
    }
}

}


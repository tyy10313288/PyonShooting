using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 5;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        
    }
   public void TakeDamage(int amount)
{
    Debug.Log("Taking damage: " + amount);
    health -= amount;
    Debug.Log("New Health: " + health);
    if (health <= 0)
    {
        Debug.Log("Player died.");
    }
}


}

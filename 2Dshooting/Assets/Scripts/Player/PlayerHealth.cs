using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth;
    public Image healthBar;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth; 
        Update();       
    }
    public void TakeDamage(int amount)
    {
        health -= amount;
        if(health <=0)
        {
            Debug.Log("die");
            SceneManager.LoadSceneAsync(2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = (float)health / maxHealth;    
    }
}

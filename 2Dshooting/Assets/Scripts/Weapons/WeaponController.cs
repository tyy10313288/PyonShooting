using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//base script for weapons

public class WeaponController : MonoBehaviour
{
    [Header("Weapon Stats")]

    public WeaponScriptableObject weaponData;

    float currentCooldown;

    protected PlayerMovement pm;

    protected virtual void Start()
    {
        pm = FindObjectOfType<PlayerMovement>();
        currentCooldown = weaponData.CooldownDuration; 
    }


    protected virtual void Update()
    {
        currentCooldown -= Time.deltaTime;
        if(currentCooldown <= 0f) 
        {
            Attack();
        }
    }

    protected virtual void Attack()
    {
        currentCooldown = weaponData.CooldownDuration;
    }
}

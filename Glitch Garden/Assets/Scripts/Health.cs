using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float currentHealth = 100f;
    [SerializeField] GameObject deathVFX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DealDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            TriggerDeathVFX();
            Destroy(gameObject);
        }
    }

    private void TriggerDeathVFX()
    {
        if (!deathVFX)
        {
            return;
        }
        GameObject deathVFXObject = Instantiate(deathVFX, transform.position, transform.rotation);
        Destroy(deathVFXObject, 1f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth; 

    public EnemysHealthBar healthBarEnemy;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBarEnemy.SetEnemyMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        


    }
    public void TakeDamage (int damage)
    {
       currentHealth   -= damage;
       healthBarEnemy.SetEnemyHealth(currentHealth);

        if (currentHealth  <= 0)
        {
            Die();
        }
    }
    void Die() 
    {
        
        Destroy(gameObject);
    }
}

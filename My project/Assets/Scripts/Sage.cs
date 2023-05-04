using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sage : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth; 

    public Healthbar healthBar;

    [Header("Variables de Animación")]
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Takedamage(20);
        }

        if(GameManager.instance.fuelementTracker == 10 ) // si la variable fuelementtracker llega a 10
        {
            animator.SetBool("EstaDisparandoFire", true);// iniciar la animación de magia
            
        }
        animator.SetBool("EstaDisparandoFire", true);

        if(GameManager.instance.fuelementTracker == 20 ) // si la variable fuelementtracker llega a 10
        {
            animator.SetBool("EstaDisparandoFire", true);// iniciar la animación de magia
            
        }
        animator.SetBool("EstaDisparandoFire", true);

        if(GameManager.instance.fuelementTracker == 30 ) // si la variable fuelementtracker llega a 10
        {
            animator.SetBool("EstaDisparandoFire", true);// iniciar la animación de magia
            
        }

        animator.SetBool("EstaDisparandoFire", true);

        //aguaaaa animation

        if((GameManager.instance.agelementTracker == 10 ) ){
            animator.SetBool("EstaDisparandoWater", true);// iniciar la animación de magia
        }

        if(GameManager.instance.agelementTracker == 20 ){
            animator.SetBool("EstaDisparandoWater", true);// iniciar la animación de magia
            
        }
        if(GameManager.instance.agelementTracker == 30 ){
            animator.SetBool("EstaDisparandoWater", true);// iniciar la animación de magia
            
        }
        
    }

    void Takedamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

        
    }
}

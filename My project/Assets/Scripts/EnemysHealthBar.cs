using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemysHealthBar : MonoBehaviour
{

    public Slider slider;
    public Gradient gradient;

    public Image fill;

    public void SetEnemyMaxHealth(int Enemyhealth)
    {
        slider.maxValue = Enemyhealth;
        slider.value = Enemyhealth; 

        fill.color = gradient.Evaluate(1f);
    }

    public void SetEnemyHealth (int Enemyhealth)
    {
        slider.value= Enemyhealth;

        fill.color = gradient.Evaluate(slider.normalizedValue);

    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

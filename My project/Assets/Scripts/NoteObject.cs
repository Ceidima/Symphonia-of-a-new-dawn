using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{

    public bool canBePressed; // si esta activo, entonces se pueden destruir las flechas al presionar el boton correcto
    public KeyCode keyToPress; // registra la tecla que se registra desde el unity
    private bool obtained = false;// para que se regitre bien el hit or miss

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress))
        {
            if (canBePressed)  // condicional
            {
                obtained=true;  // si se cumple la condicion sucedera esto
                gameObject.SetActive (false);  // se destruira el objeto
                
                //GameManager.instance.NoteHit();  // en el log aparecera como hit

                if (Mathf.Abs(transform.position.y) >= 0.25f) // estas lineas son para que detecte que hit son dependiendo de la distancia en la que se encuentren de y= 0
                {
                    Debug.Log("meh");
                    GameManager.instance.Normalhit();
                }
                else if (Mathf.Abs(transform.position.y) <= 0.24f && Mathf.Abs(transform.position.y) > 0.05f)
                {
                    Debug.Log("wena");
                    GameManager.instance.Goodhit();
                }

                else if (Mathf.Abs(transform.position.y) <= 0.04f && Mathf.Abs(transform.position.y) > 0.00f)
                {
                    Debug.Log("perfect o");
                    GameManager.instance.Perfecthit();
                }

            }

        }
    }

   private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.tag == "Activator")
        {
            canBePressed = true;
        }
    }
    
    private void OnTriggerExit2D(Collider2D other) {
        
        if(other.tag == "Activator")
        {
            canBePressed = false;
            if (!obtained){
                GameManager.instance.NoteMissed();
            }
        }
    }


}

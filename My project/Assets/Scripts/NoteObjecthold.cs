using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObjecthold : MonoBehaviour
{
    public bool canBePressed; // si esta activo, entonces se pueden destruir las flechas al presionar el boton correcto
    public KeyCode keyToPress; // registra la tecla que se registra desde el unity
    private bool obtained = false; // para que se regitre bien el hit or miss

    public float requiredHoldTime = 1.0f; // tiempo en segundos que se debe mantener el botón presionado
    private float currentHoldTime = 0.0f; // tiempo actual que se ha mantenido presionado el botón

void Update()
{
    if (Input.GetKey(keyToPress))
    {
        if (canBePressed)
        {
            currentHoldTime += Time.deltaTime; // sumamos el tiempo que ha pasado en este frame
            if (currentHoldTime >= requiredHoldTime) // si ha pasado el tiempo requerido
            {
                GameManager.instance.Normalhit(); // cuenta como un hit normal
                obtained = true;
                currentHoldTime = 0.0f; // reiniciamos el tiempo
            }
        }
    }
    else
    {
        currentHoldTime = 0.0f; // reiniciamos el tiempo si no se mantiene presionado el botón
    }
}


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Activator")
        {
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.tag == "Activator")
        {
            canBePressed = false;
            if (!obtained)
            {
                GameManager.instance.NoteMissed();
            }
        }
    }

}

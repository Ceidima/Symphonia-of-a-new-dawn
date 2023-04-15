using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{
    public float beatTempo; //que tan rapido van a caer las flechas
    public bool  hasStarted; //nuestra manera de verificar que inicia con un boton

    //120 beats por minuto se divide por 60, lo cual da alrededor de 2 beats por segundo


    // Start is called before the first frame update
    void Start()
    {
        beatTempo = beatTempo/60f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            /*if(Input.anyKeyDown)
            {
                hasStarted = true;
            }*/            
        } 
            else
        {
            transform.position -=new Vector3(0f,beatTempo * Time.deltaTime, 0f); // el 0f por que queremos que se mueva
                                                                            //solo en eje Y 

        }
    }
}

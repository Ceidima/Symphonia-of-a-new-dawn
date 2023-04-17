using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{       
    private SpriteRenderer theSR; //Necesitamos acceder a la funcion que renderiza al sprite, por lo que creamos thesr ("sprite renderer") para llamarlo
    public Sprite  defaultImage; //aqui señalo el como se vera por dafault  
    public Sprite  pressedImage; // aqui el como se vera presionada

    public KeyCode keyToPress;
    // Start is called before the first frame update
    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();




    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress))
        {
            theSR.sprite = pressedImage;

        }
        if(Input.GetKeyUp(keyToPress))
        {
            theSR.sprite = defaultImage;
        }
    }
}

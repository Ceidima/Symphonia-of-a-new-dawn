using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // aquí un key to press
    public KeyCode keyToPress;
    /////////////////////////////
    public AudioSource theMusic;
    public bool startPlaying;
    public BeatScroller theBS;
    public static GameManager instance;
    public int CurrentScore;
    // nuevas cosas para perfect score ------>no importa por ahora
    public int ScorePerNote = 100;
    public int ScorePerGoodnote = 125;
    public int ScorePerPerfectnote = 150;

    // aquí comienza los arrays de trackers
    // fuego
    public int fucurrentElmtTrack;
    public int fuelementTracker;

    public int[] fuelementThresholds;
    // Agua
    public int agcurrentElmtTrack;
    public int agelementTracker;

    public int[] agelementThresholds;
    // Tierra
    public int ticurrentElmtTrack;
    public int tielementTracker;

    public int[] tielementThresholds;
    // Aire
    public int aicurrentElmtTrack;
    public int aielementTracker;

    public int[] aielementThresholds;

    // a partir de es texto en canvas-----> de momento no sirve
    // aquí Cambio elemental
    public bool Fuego = false;
    public bool Agua = false;
    public bool Tierra = false;
    public bool Aire = false;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        fucurrentElmtTrack = 1;
        // aquí fuego al iniciar el juego
        Fuego = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!startPlaying)
        {
            if (Input.anyKeyDown)
            {
                startPlaying = true;
                theBS.hasStarted = true;

                theMusic.Play();
            }
        }
        // elementos
        if (Input.GetKeyDown(KeyCode.E))
        {
            Agua = true;
            Tierra = false;
            Aire = false;
            Fuego = false;
            Debug.Log("Cambio a Agua");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Agua = false;
            Tierra = true;
            Aire = false;
            Fuego = false;
            Debug.Log("Cambio a Tierra");
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            Agua = false;
            Tierra = false;
            Aire = true;
            Fuego = false;
            Debug.Log("Cambio a Aire");
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            Agua = false;
            Tierra = false;
            Aire = false;
            Fuego = true;
            Debug.Log("Cambio a Fuego");
        }

    }

    

public void NoteHit()
{
    if (Fuego)
    {
        if (fucurrentElmtTrack - 1 < fuelementThresholds.Length) // esto es un seguro para que no siga avanzando si supera el largo  del arreglo
        {
            fuelementTracker++; //para que comience a contar los puntos necesarios para que avance el multiplicador
        }

    }

    if (Agua)
    {
        if (agcurrentElmtTrack - 1 < agelementThresholds.Length) // esto es un seguro para que no siga avanzando si supera el largo  del arreglo
        {
            agelementTracker++; //para que comience a contar los puntos necesarios para que avance el multiplicador

        }

    }

    if (Tierra)
    {
        if (ticurrentElmtTrack - 1 < tielementThresholds.Length) // esto es un seguro para que no siga avanzando si supera el largo  del arreglo
        {
            tielementTracker++; //para que comience a contar los puntos necesarios para que avance el multiplicador


        }

    }

    if (Aire)
    {
        if (aicurrentElmtTrack - 1 < aielementThresholds.Length) // esto es un seguro para que no siga avanzando si supera el largo  del arreglo
        {
            aielementTracker++; //para que comience a contar los puntos necesarios para que avance el multiplicador


        }

    }


    Debug.Log(fucurrentElmtTrack);

}




    public void Normalhit()
    {   
   
        NoteHit();
    }

    public void Goodhit()
    {

        NoteHit();
    }
    
    public void Perfecthit()
    {

        NoteHit();

    }

    public void NoteMissed()
    {
        Debug.Log("Missed Log");
        
    }
}

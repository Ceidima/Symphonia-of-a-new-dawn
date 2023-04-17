using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;
    public bool startPlaying;
    public BeatScroller theBS;
    public static GameManager instance; 
    public int CurrentScore;
    //nuevas cosas para perfect score
    public int ScorePerNote = 100;
    public int ScorePerGoodnote = 125;
    public int ScorePerPerfectnote = 150;

    //aqui comienza los multiplier

    public int currentMultiplier;
    public int multiplierTracker;

    public int[] multiplierThresholds;

    



    //a partir de es texto en canvas
    public Text scoreText;
    public Text multiText;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        scoreText.text = "Score: 0 ";
        currentMultiplier = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(!startPlaying)
        {
            if(Input.anyKeyDown){
                startPlaying= true;
                theBS.hasStarted = true;

                theMusic.Play();
            }
        }
    }

    public void NoteHit()
    {
        //Debug.Log("Hit on Time");

        if(currentMultiplier - 1  < multiplierThresholds.Length) // esto es un seguro para que no siga avanzando si supera el largo  del arreglo
        {
            multiplierTracker ++; //para que comience a contar los puntos necesarios para que avance el multiplicador

            if(multiplierThresholds[currentMultiplier-1] <= multiplierTracker)  // para que avance y se reincie el tracker y el multiplier, busca la 
            {                                                                   //posicion del arreglo  0 por eso el -1
              multiplierTracker = 0;
              currentMultiplier++;     
            }

        }

        multiText.text = "Multiplier : x " + currentMultiplier;
        

        //CurrentScore += ScorePerNote * currentMultiplier;
        scoreText.text = "Score " + CurrentScore;
    }

    public void Normalhit()
    {   
        CurrentScore += ScorePerNote * currentMultiplier;
        NoteHit();
    }

    public void Goodhit()
    {
        CurrentScore += ScorePerGoodnote * currentMultiplier;
        NoteHit();
    }
    
    public void Perfecthit()
    {
        CurrentScore += ScorePerPerfectnote * currentMultiplier;
        NoteHit();

    }

    public void NoteMissed()
    {
        Debug.Log("Missed Log");
        
        currentMultiplier = 1;
        multiplierTracker = 0;

        multiText.text = "Multiplier : x " + currentMultiplier;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic : MonoBehaviour
{
    public Transform firePPoint;
    public Transform WaterPoint;
    public GameObject FuegoPrefab;
    public GameObject AguaPrefab;
    public GameObject TierraPrefab;
    public GameObject AirePrefab;
    private bool hasShot = false;
    public int fucontador = 0;
    public int agcontador = 0;
    public int ticontador = 0;
    public int aicontador = 0;




    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   

        //seccion de fuego
        if((GameManager.instance.fuelementTracker == 10 ) && !hasShot && fucontador==0){
            ShootFuego();
            
        }

        if((GameManager.instance.fuelementTracker == 20 ) && !hasShot && fucontador== 1){

            ShootFuego();
        }

        if((GameManager.instance.fuelementTracker == 30 ) && !hasShot && fucontador== 2){

            ShootFuego();
        }
//------------------------------------------------------------------------------------------------------------------
        // seccion de agua
        if((GameManager.instance.agelementTracker == 10 ) && !hasShot && agcontador==0){
            ShootAgua();
            
        }

        if((GameManager.instance.agelementTracker == 20 ) && !hasShot && agcontador== 1){

            ShootAgua();
        }

        if((GameManager.instance.agelementTracker == 30 ) && !hasShot && agcontador== 2){

            ShootAgua();
        }
//------------------------------------------------------------------------------------------------------------------

        //seccion de tierra
        if((GameManager.instance.tielementTracker == 10 ) && !hasShot && ticontador==0){
            ShootTierra();
            
        }

        if((GameManager.instance.tielementTracker == 20 ) && !hasShot && ticontador== 1){

            ShootTierra();
        }

        if((GameManager.instance.tielementTracker == 30 ) && !hasShot && ticontador== 2){

            ShootTierra();
        }
//------------------------------------------------------------------------------------------------------------------

        // seccion de aire
        if((GameManager.instance.aielementTracker == 10 ) && !hasShot && aicontador==0){
            ShootAire();
            
        }

        if((GameManager.instance.aielementTracker == 20 ) && !hasShot && aicontador== 1){

            ShootAire();
        }

        if((GameManager.instance.aielementTracker == 30 ) && !hasShot && aicontador== 2){

            ShootAire();
        }
        
    }

    
//seccion de fuego
    void ShootFuego()
    {
        if (!hasShot){
            Instantiate(FuegoPrefab, firePPoint.position , firePPoint.rotation); /* el instantiate es para poder spawnear cosas, en este caso crea la magia que actualmente estamos usando */
            hasShot = true;
            fucontador++;
        } 
        hasShot = false;    
    }
//------------------------------------------------------------------------------------------------------------------
        // seccion de agua
    void ShootAgua()
    {
        if (!hasShot){
            Instantiate(AguaPrefab, WaterPoint.position , WaterPoint.rotation); /* el instantiate es para poder spawnear cosas, en este caso crea la magia que actualmente estamos usando */
            hasShot = true;
            agcontador++;
        } 
        hasShot = false;    
    }
//------------------------------------------------------------------------------------------------------------------

        //seccion de tierra
    void ShootTierra()
    {
        if (!hasShot){
            Instantiate(TierraPrefab, firePPoint.position , firePPoint.rotation); /* el instantiate es para poder spawnear cosas, en este caso crea la magia que actualmente estamos usando */
            hasShot = true;
            ticontador++;
        } 
        hasShot = false;    
    }
//------------------------------------------------------------------------------------------------------------------

        // seccion de aire
    void ShootAire()
    {
        if (!hasShot){
            Instantiate(AirePrefab, firePPoint.position , firePPoint.rotation); /* el instantiate es para poder spawnear cosas, en este caso crea la magia que actualmente estamos usando */
            hasShot = true;
            aicontador++;
        } 
        hasShot = false;    
    }







}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DetectionMiddleFinger : MonoBehaviour
{
    public GameObject cubo;
    public GameObject robot;
    public Transform Finger;
    //public Transform point;
    //private int puntos;
    //public TMP_Text Puntaje;

    private bool activo;


    void Update()
    {
        if (activo == true){
            
            //puntos+=puntos;
            //Puntaje.text = puntos.ToString();
            Destroy(robot);
            Destroy(cubo);
            //if (Input.GetKeyDown(KeyCode.E)){
            //cubo.transform.SetParent(Finger);
            //cubo.transform.position = Finger.position;
            //GetComponent<Rigidbody>().isKinematic = true; 
            //}
        }
        //if (activo == false){
            //cubo.transform.SetParent(robot);
            //cubo.transform.position = robot.position;
            //GetComponent<Rigidbody>().isKinematic = true; 
       // }
       
        
        
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag == "Middle_Finger"){
            activo = true;
        }
    }
    //void OnTriggerExit(Collider other){
        //if(other.tag == "Capture_Blue"){
            //activo = false;
        //}
    //}
}


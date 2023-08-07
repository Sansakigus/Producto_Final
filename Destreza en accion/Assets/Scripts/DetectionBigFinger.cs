using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DetectionBigFinger : MonoBehaviour
{
    public GameObject cubo;
    public GameObject robot;
    public Transform Finger;
   

    private bool activo;

    void Update()
    {
        if (activo == true){
            Destroy(robot);
            Destroy(cubo);
           
        }
    
    }
    private void OnTriggerEnter(Collider other){
        if(other.tag == "Big_Finger"){
            activo = true;
        }
    }
}

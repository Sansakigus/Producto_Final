using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    public GameObject cubo;
    public Transform Finger;
    //public Transform point;
    private bool activo;
    // Update is called once per frame
    void Update()
    {
        if (activo == true){
            cubo.transform.SetParent(Finger);
            cubo.transform.position = Finger.position;
            cubo.GetComponent<Rigidbody>().isKinematic = true; 
        
        }
        //if (activo == false){
            //cubo.transform.SetParent(null);
            //cubo.GetComponent<Rigidbody>().isKinematic = false;
       // }
        
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag == "Capture"){
            activo = true;
        }
    }
    void OnTriggerExit(Collider other){
        if(other.tag == "Big_Finger"){
            activo = false;
        }
    }
}

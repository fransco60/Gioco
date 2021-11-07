using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avvio : MonoBehaviour
{
   
    public GameObject Guardare;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(scritta.contatore == 1)
        {
            new WaitForSeconds(1);
            Debug.Log("culo");
            GetComponent<playerscript>().enabled = true;
            Guardare.GetComponent<MouseLook>().enabled = true;
            GetComponent<CharacterController>().enabled = true;
            if (Guardare.GetComponent<MouseLook>().enabled == true && GetComponent<playerscript>().enabled == true && GetComponent<CharacterController>().enabled == true)
            {
                GetComponent<avvio>().enabled = false;
            }
 
        }
       
    }
}

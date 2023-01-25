using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Me_Rompo : MonoBehaviour
{
     public bool terremoto=false;
    
    void Update()
    {
        if (terremoto)
        {
            GetComponent<Rigidbody>().isKinematic = false;
        }
        
    }
}

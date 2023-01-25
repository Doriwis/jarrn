using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Me_Rompo : MonoBehaviour
{
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {  
    }

    public void ActivarTerremoto()
    {
        rb.isKinematic = false;
    }
}

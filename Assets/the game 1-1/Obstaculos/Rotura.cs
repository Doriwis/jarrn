using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotura : MonoBehaviour
{
    [SerializeField] GameObject[] rocas;


    Collider call;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Destroy"))
        {
             call=GetComponent<Collider>();
            call.enabled = false;
            Debug.Log("player detectado");
            for (int i = 0; i < rocas.Length; i++)
            {
                rocas[i].GetComponent<Me_Rompo>().ActivarTerremoto();
            }
            
        }
    }
}

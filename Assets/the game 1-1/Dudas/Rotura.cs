using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotura : MonoBehaviour
{
    [SerializeField] GameObject[] rocas;
    

    
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Destroy"))
        {
            Debug.Log("player detectado");
            GetComponent<Rigidbody>().isKinematic = false;
            for (int i = 0; i < rocas.Length; i++)
            {
                rocas[i].GetComponent<Me_Rompo>().terremoto = true;
            }
            
        }
    }
}

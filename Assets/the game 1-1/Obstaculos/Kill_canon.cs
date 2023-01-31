using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_canon : MonoBehaviour
{
    [SerializeField] GameObject bala;
    [SerializeField] int ponits;
   
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Destroy"))
        {
            collision.gameObject.GetComponent<Character1>().contador +=ponits;
            bala.GetComponent<Canon>().dead = true;
            Destroy(this.gameObject);
        }
    }
}

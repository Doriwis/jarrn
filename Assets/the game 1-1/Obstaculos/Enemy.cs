using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    

    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Character1>().live--;
        }
        if (collision.gameObject.CompareTag("Destroy"))
        {
            collision.gameObject.GetComponent<Character1>().contador += 2;
            Destroy(this.gameObject);

        }

    }
}

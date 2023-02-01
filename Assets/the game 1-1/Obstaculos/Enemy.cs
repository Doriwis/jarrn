using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int point=2;

    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Character1>().live--;
            collision.transform.position = collision.gameObject.GetComponent<Character1>().checkpoint;
            
        }
        if (collision.gameObject.CompareTag("Destroy"))
        {
            collision.gameObject.GetComponent<Character1>().contador += point;
            Destroy(this.gameObject);

        }

    }
}

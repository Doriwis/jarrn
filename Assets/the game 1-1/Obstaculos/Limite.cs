using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limite : MonoBehaviour
{







    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")||other.gameObject.CompareTag("Destroy") )
        {
            other.GetComponent<Character1>().live--;
            other.transform.position = other.gameObject.GetComponent<Character1>().checkpoint;
        }
    }
}

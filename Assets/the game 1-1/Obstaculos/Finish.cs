using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Destroy")|| other.CompareTag("Player"))
        {
            SceneManager.LoadScene(3);
        }
    }
}

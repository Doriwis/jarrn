using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara1 : MonoBehaviour
{
    [SerializeField] GameObject character;
    Vector3 distancia;
    // Start is called before the first frame update
    void Start()
    {
        distancia = character.transform.position - transform.position;
    }

    private void LateUpdate()
    {
        transform.position = character.transform.position - distancia;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mi_camera : MonoBehaviour
{
    [SerializeField] GameObject bola;
    Vector3 distancia;
    // Start is called before the first frame update
    void Start()
    {
        distancia = transform.position;
    }
    //lateupdate:des pes de todos los update

    // Update is called once per frame
    void Update()
    {
        transform.position = bola.transform.position + distancia;
    }
}

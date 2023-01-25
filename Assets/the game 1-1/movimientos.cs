using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientos : MonoBehaviour
{
    public float velocidad;
    public Vector3 start;
    public float ampitud;
    public Vector3 direcion;
    public float desfase;
    void Start()
    {
        ampitud = 5;
        start = transform.position;
        direcion = new Vector3(0, 0, 1);
        velocidad = 5;
        desfase = 0;
    }

    
    public void MovimientoNaranja()
    {
        float seno = ampitud + Mathf.Sin((velocidad * Time.time) + desfase);
        transform.position = start + (direcion * seno);
    }

}


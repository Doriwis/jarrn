using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    movimientos move = new movimientos();
    // Start is called before the first frame update
    void Start()
    {
        move.ampitud = 5;
        move.start = transform.position;
        move.direcion = new Vector3(0, 0, 1);
        move.velocidad = 5;
        move.desfase = 0;
    }
    // Update is called once per frame
    void Update()
    {
        move.MovimientoNaranja();
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Character>().live--;
        }
        if (collision.gameObject.CompareTag("Destroy"))
        {
            collision.gameObject.GetComponent<Character>().contador += 2;
            Destroy(this.gameObject);

        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]public float velocidad;
    [SerializeField] public Vector3 start;
    [SerializeField] public float ampitud = 1;
    [SerializeField] public Vector3 direcion = new Vector3(0, 0, 1);
    [SerializeField] public float desfase;
    

    void Start()
    {
        
        start = transform.position;
        
        
    }
    // Update is called once per frame
    void Update()
    {
        float seno = ampitud * Mathf.Sin((velocidad * Time.time) + desfase);
        transform.position = start + (direcion * seno);
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

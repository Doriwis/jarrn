using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
   public bool dead;
   public string paso;

    [SerializeField] Vector3 direc;
    [SerializeField] string eje = "";
    [SerializeField] string mM;
    [SerializeField] int limt;




    [SerializeField] float veloc;



    Vector3 pInicial;
    private void Start()
    {
        pInicial=transform.position;
    }
    private void Update()
    {
        if (paso=="shot")
        {
            transform.Translate(direc.normalized * veloc * Time.deltaTime,Space.World);
        }



        //limite de Mq o mq yque eje


        if (mM=="M")
        {
            if (eje=="z")
            {
                if (transform.position.z > limt)
                {
                    transform.position = pInicial;
                }
            }
            if (eje == "x") 
            {
                if (transform.position.x > limt)
                {
                    transform.position = pInicial;
                }
            }

            if (eje == "y")
            {
                if (transform.position.y > limt)
                {
                    transform.position = pInicial;
                }
            }

        }
        else
        {
            if (eje == "z")
            {
                if (transform.position.z < limt)
                {
                    transform.position = pInicial;
                }
            }
            if (eje == "x")
            {
                if (transform.position.x < limt)
                {
                    transform.position = pInicial;
                }
            }

            if (eje == "y")
            {
                if (transform.position.y < limt)
                {
                    transform.position = pInicial;
                }
            }
        }


       


        if (dead)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")|| collision.gameObject.CompareTag("Destroy"))
        {
            collision.gameObject.GetComponent<Character1>().live--;
            collision.transform.position = collision.gameObject.GetComponent<Character1>().checkpoint;
        }
    }
}

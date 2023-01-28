using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_F : MonoBehaviour
{
     public Vector3 start;
    [SerializeField] public string paso="";

    [SerializeField] public Vector3 direcion ;

    [SerializeField] public float velocidad;
    [SerializeField] public float ampitud ;
    [SerializeField] public float desfase;

    [SerializeField] public float velocidadR;
    [SerializeField] string eje;
    [SerializeField] float min;
    [SerializeField] float max;

    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (paso == "movR")
        {


            if (eje=="x")
            {
               
                MovRectilineoX();
            }
            else if (eje=="z")
            {
                
                MovRectilineoZ();
            }
            else if(eje=="y")
            {
               
                MovRectilineoY();
            }


        }

        else if (paso == "movO")
        {


            MovOndulatorio();



        }



    }

    void MovOndulatorio()
    {
        float seno = ampitud * Mathf.Sin((velocidad * Time.time) + desfase);
        transform.position = start + (direcion * seno);
    }
    void MovRectilineoZ()
    {
        transform.Translate(direcion* velocidadR * Time.time, Space.World);
        float clamp= Mathf.Clamp(transform.position.z, min, max);
        transform.position= new Vector3(transform.position.x,transform.position.y,clamp);
    }
    void MovRectilineoX()
    {
        transform.Translate(direcion * velocidadR * Time.time, Space.World);
        float clamp = Mathf.Clamp(transform.position.x, min, max);
        transform.position = new Vector3(clamp, transform.position.y, transform.position.z);
    }
    void MovRectilineoY()
    {
        transform.Translate(direcion * velocidadR * Time.time);

        float clamp = Mathf.Clamp(transform.position.y, min, max);
        
        transform.position = new Vector3(transform.position.x, clamp , transform.position.z);
    }

}
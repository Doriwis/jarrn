using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]LayerMask capa;
    [SerializeField] LayerMask cap2;
    float h;
    float masa;
    float forcejump;
    public int live;
    Vector3 start;
    float velocidad = 5; //velocidad m/s
    float escalaGravedad = -9.81f;
    Vector3 checkpoint;
    public int contador;

    
    public int camara = 0;
    
    void Start()
    {
        live = 3;
        start = transform.position;
        checkpoint = transform.position;
       forcejump = 15;
        rb = GetComponent<Rigidbody>();
       
    }




    
    void Update()
    {
        AplicarGravedad();


        float v = Input.GetAxisRaw("Vertical");
        h = Input.GetAxisRaw("Horizontal");

        


        //Salto
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            //Compruevo que esto suelo
            if (EstoySaltando())
            {
                
                rb.AddForce(new Vector3(0, 1, 0) * forcejump, ForceMode.Impulse);
                
            }
            
        }

        
        //salto y deslizamiento 
        if (PegadoPared()=="R"|| PegadoPared() == "L")
        {
            escalaGravedad /= 2;
            //compruevo R o L
            if (PegadoPared() == "L")
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    rb.AddForce(new Vector3(0, 1, 0) * (forcejump*1.5f ), ForceMode.Impulse);
                    rb.AddForce(new Vector3(0, 0, 1) * (3), ForceMode.Impulse);
                }
                    
            }
            if (PegadoPared() == "R")
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    rb.AddForce(new Vector3(0, 1, 0) * (forcejump*1.5f), ForceMode.Impulse);
                    rb.AddForce(new Vector3(0, 0, -1) * (3), ForceMode.Impulse);
                }
                    
            }


        }
        else
        {
            escalaGravedad = -9.81f * 1.5f;


        }
        
        //Dash down
        if (Input.GetKeyDown(KeyCode.LeftShift) && !EstoySaltando())
        {
            rb.AddForce(new Vector3(0, -1, 0) * 70, ForceMode.Impulse);
        }

        //Dashses r l
        float dash=120;
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(new Vector3(0, 0, h) * dash, ForceMode.Impulse);
        }
        if (Input.GetMouseButtonDown(1))
        {
            rb.AddForce(new Vector3(0, 0, -h) * dash, ForceMode.Impulse);
        }

    }
  
    



    // movimiento continuo
    void FixedUpdate()
    {
        //Leo la velocidad actual que lleva la bola
        Vector3 currentVelocity = rb.velocity;

        //Calculo la velocidad que quiero llevar.
        Vector3 targetVelocity = new Vector3(0, 0, h) * velocidad;

        //Calculo la diferencia entre la velocidad que quiero alcanzar y la que llevo actualmente.
        Vector3 velocityChange = (targetVelocity - currentVelocity);

        velocityChange = new Vector3(velocityChange.x, 0, velocityChange.z);

        rb.AddForce(velocityChange, ForceMode.VelocityChange);

    }

    string PegadoPared()
    {
        string resultado= "";
        
        if (Physics.Raycast(transform.position, new Vector3(0, 0, -1), 1.01f, cap2))
        {
            resultado = "L";
        }
        if(Physics.Raycast(transform.position, new Vector3(0, 0, 1), 1.01f, cap2))
        {
            resultado = "R";
        }
        
        return resultado;

    }

    bool EstoySaltando()
    {
        bool resultado = false;

        resultado=Physics.Raycast(transform.position, new Vector3(0, -1, 0), 1.1f,capa );
        return resultado;
    }

    void AplicarGravedad()
    {
        rb.velocity += new Vector3(0, escalaGravedad, 0) * Time.deltaTime; //9.8 m /s
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("rotation"))
        {
            camara=1;
        }
        else if (other.gameObject.CompareTag("giro"))
        {
            camara = -1;
        }
        else if (other.gameObject.CompareTag("checkpoint"))
        {
            checkpoint=transform.position;
        }
        else if (other.gameObject.CompareTag("rotura"))
        {
            other.GetComponent<Rigidbody>().isKinematic = false;
        }

    }
    void Respawn()
    {
       
        live--;
        
        if (live <= 0)
        {
            live = 3;
            transform.position = start;
        }
        else
        {
            transform.position = checkpoint;
        }

    }
}

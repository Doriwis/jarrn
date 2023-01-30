using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTarget : MonoBehaviour
{
    [SerializeField] GameObject player;
    
    int rota;
    Character1 ch;
    // Start is called before the first frame update
    void Start()
    {
        ch = player.GetComponent<Character1>();
      
    }

    // Update is called once per frame
    void Update()
    {
        rota = ch.camara;
        transform.position = player.transform.position;
        if(rota==1)
        {
            StartCoroutine(CambiarRotacion());
            

        }
        if (rota==-1)
        {
            StartCoroutine(StartRotacion());
           
           
        }
    }

    public IEnumerator CambiarRotacion()
    {
        Quaternion rotacionInicial = transform.rotation;
        Quaternion rotacionFinal = Quaternion.Euler(0, 90, 0);
        float timer = 0;
        float tiempoTotal = 0.75f;
        
        while (timer < tiempoTotal)
        {
            transform.rotation = Quaternion.Slerp(rotacionInicial, rotacionFinal, timer / tiempoTotal);
            timer += 1 * Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
    }
    public IEnumerator StartRotacion()
    {
        Quaternion rotacionInicial = transform.rotation;
        Quaternion rotacionFinal = Quaternion.Euler(0, 0, 0);
        float timer = 0;
        float tiempoTotal = 0.75f;
        while (timer < tiempoTotal)
        {
            transform.rotation = Quaternion.Slerp(rotacionInicial, rotacionFinal, timer / tiempoTotal);
            timer += 1 * Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

    }
    
    

}
    

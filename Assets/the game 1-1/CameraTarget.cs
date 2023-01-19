using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTarget : MonoBehaviour
{
    [SerializeField] GameObject player;
    bool rota;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
        if(rota)
        {
            StartCoroutine(CambiarRotacion());
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

    IEnumerator MiMetodo()
    {
        Debug.Log("Rojo");
        yield return new WaitForSeconds(1f);
        Debug.Log("Amarillo");
        yield return new WaitForSeconds(1f);
        Debug.Log("vverdfe");
    }
}

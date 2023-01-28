using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{ [SerializeField]GameObject obj;
    [SerializeField] string yo;
    // Start is called before the first frame update


    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Destroy"))
        {
            obj.GetComponent<Movimiento_F>().paso = yo;
        }
    }
}

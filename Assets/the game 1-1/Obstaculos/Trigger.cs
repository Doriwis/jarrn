using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{ [SerializeField]GameObject[] obj;
    [SerializeField] string yo;
    
    
    // Start is called before the first frame update


    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Destroy"))
        {
            if (yo=="movR"||yo=="movO")
            {
                for (int i = 0; i < obj.Length; i++)
                {
                    obj[i].GetComponent<Movimiento_F>().paso = yo;

                }
            }
            if (yo=="shot")
            {
                for (int i = 0; i < obj.Length; i++)
                {
                    obj[i].GetComponent<Canon>().paso = yo;

                }
            }
            
            
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points : MonoBehaviour
{
    [SerializeField] int point = 1;
   
    void Update()
    {
        transform.Rotate(new Vector3(0,1, 0) * 100 * Time.deltaTime,Space.World);

        transform.Rotate(new Vector3(0, 1, 0) * 75 * Time.deltaTime, Space.World);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Destroy") )
        {
            other.GetComponent<Character1>().contador+=point;
            Destroy(this.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,1, 0) * 100 * Time.deltaTime,Space.World);

        transform.Rotate(new Vector3(0, 1, 0) * 75 * Time.deltaTime, Space.World);

    }
}
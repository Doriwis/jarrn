using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampas : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        
    }
    void Down()
    {
        transform.Translate(new Vector3(0, -1, 0) * 10 * Time.deltaTime);
    }
    void MO()
    {

    }
}

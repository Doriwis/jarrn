using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rodillo : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float fuerza;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddTorque(new Vector3(0, 01, 0) * fuerza, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

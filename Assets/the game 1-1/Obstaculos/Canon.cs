using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
   public bool dead;
    public string mov;
    [SerializeField] Vector3 direc;
    [SerializeField] float veloc;
    private void Update()
    {
        if (mov=="movR")
        {
            transform.Translate(direc * veloc * Time.time);
        }
        if (dead)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")|| collision.gameObject.CompareTag("Destroy"))
        {
            collision.gameObject.GetComponent<Character1>().live--;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    public int waterForce = 25;
    public Transform waterOrigin;
    public bool contact = false;
    
     void OnTriggerStay2D(Collider2D other)
    {
        Vector2 waterFlow = transform.position - waterOrigin.transform.position;
        other.GetComponent<Rigidbody2D>().AddForce(waterFlow * waterForce);
        contact = true;
    }
}

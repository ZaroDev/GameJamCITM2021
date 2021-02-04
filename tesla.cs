using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tesla_Tower : MonoBehaviour
{
    public int force = 10;
    public bool isActive = false;
    private void Update()
    {
        if (Input.GetKey(KeyCode.E)) isActive = !isActive;
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if ((other.tag == "Metallic") && (isActive))
        {
            Vector2 attraction = gameObject.transform.position - other.transform.position;
            other.GetComponent<Rigidbody2D>().AddForce(attraction * force);
        }
        
    }
}

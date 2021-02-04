using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle_Collider_Enabled : MonoBehaviour
{
    public bool toggle = false;
    public bool activate = false;
    public bool deactivate = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            ToggleCollider();
            activate = true;
        }
        
        if (Input.GetKey(KeyCode.Q))
        {
            ToggleCollider();
            deactivate = true;
        }
        //if (toggle) ToggleCollider();
    }
    public void ToggleCollider()
    {
        if (activate == true) gameObject.GetComponent<Collider2D>().enabled = true;
        else if (deactivate == true) gameObject.GetComponent<Collider2D>().enabled = false;
        //gameObject.GetComponent<Collider2D>().enabled = !gameObject.GetComponent<Collider2D>().enabled;
        activate = false;
        deactivate = false;

    }
}

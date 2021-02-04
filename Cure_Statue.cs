using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cure_Statue : MonoBehaviour
{
    public int state = 0;
    public Animation anim;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (state == 0)
        {
            anim.Play("Statue");
        }
        else if (state == 1)
        {
            anim.Play("Cured");
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Cure Platform") state = 1;
    }
}

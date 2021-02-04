using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speedX = 5.0f;
    public float speedY = 5.0f;
    private float inputX = 0;

    
    private bool onTheFloor = false;
    public Transform foot;
    public float footRadious = 0.3f;
    public LayerMask floor;
    
    // Start is called before the first frame update
    void Start()
    {
      

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        inputX = Input.GetAxisRaw("Horizontal");
        speedY = gameObject.GetComponent<Rigidbody2D>().velocity.y;
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(inputX * speedX, speedY);
        onTheFloor = Physics2D.OverlapCircle(foot, footRadious, floor);
        if(Input.GetKeyDown(KeyCode.Space) && (onTheFloor)) Jump();
        
        
    }
    void Jump ()
    {
        speedY = 5.0f;
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (gameObject.GetComponent<Rigidbody2D>().velocity.x, speedY);
        onTheFloor = false;
    }
}

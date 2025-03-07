using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 5.75f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }

    void movement()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.S)) 
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
    }
}

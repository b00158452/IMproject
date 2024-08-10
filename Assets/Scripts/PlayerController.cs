using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forwardSpeed = 7f;
    private float sideSpeed = 7f;

  

    // Start is called before the first frame update
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
        float horizontalInput=Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * sideSpeed * horizontalInput * Time.deltaTime);
    }

    
}

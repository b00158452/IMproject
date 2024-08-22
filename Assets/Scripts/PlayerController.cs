using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forwardSpeed = 7f;
    private float sideSpeed = 7f;
    public float jumpForce = 6f;

    private Rigidbody rb;
    private bool isGrounded = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime); //forward movement
        float horizontalInput=Input.GetAxis("Horizontal"); // taking info about horizontal axe
        transform.Translate(Vector3.right * sideSpeed * horizontalInput * Time.deltaTime); // side movement

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isGrounded = false;
        Audio.instance.PlaySFX(1);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

}

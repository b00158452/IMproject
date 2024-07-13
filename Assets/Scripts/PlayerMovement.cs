using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2.0f;
    public float turnSpeed = 45.0f;
    public float horizontalInput;
    public float forwardInput = 1.0f; // Set forwardInput to 1 to start running

    void Update()
    {
        // Get input for horizontal movement
        horizontalInput = Input.GetAxis("Horizontal");

        // Moves the player forward based on forwardInput (set to 1 for continuous movement)
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Rotates the player based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}

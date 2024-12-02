using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrogonController : MonoBehaviour
{
    [SerializeField] private float speed = 5f; // Speed at which the dragon moves
    [SerializeField] private float rotationSpeed = 5f; // Speed for smooth rotation
    [SerializeField] private float movementSmoothness = 0.1f; // Smoothing factor for movement

    private FixedJoystick joystick; // Reference to the joystick component for player input
    private Rigidbody rb; // Rigidbody for physics-based movement
    private Vector3 currentVelocity; // Used to track velocity for smoothing movement

    private void OnEnable()
    {
        // Find and assign the FixedJoystick in the scene
        joystick = FindObjectOfType<FixedJoystick>();
        // Get the Rigidbody attached to this GameObject
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        // Read input from the joystick
        float xValue = joystick.Horizontal; // Horizontal input from the joystick
        float yValue = joystick.Vertical; // Vertical input from the joystick

        // Calculate the target movement vector in the X-Z plane
        Vector3 targetMovement = new Vector3(xValue, 0, yValue) * speed;

        // Smoothly interpolate between the current velocity and the target velocity
        Vector3 smoothedMovement = Vector3.SmoothDamp(rb.velocity, targetMovement, ref currentVelocity, movementSmoothness);

        // Apply the smoothed velocity to the Rigidbody
        rb.velocity = smoothedMovement;

        // If there's input from the joystick, rotate the dragon
        if (xValue != 0 || yValue != 0)
        {
            // Calculate the target angle in the X-Z plane based on the joystick input
            float targetAngle = Mathf.Atan2(xValue, yValue) * Mathf.Rad2Deg;

            // Create a Quaternion representing the desired rotation
            Quaternion targetRotation = Quaternion.Euler(0, targetAngle, 0);

            // Smoothly interpolate the dragon's current rotation to the target rotation
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.fixedDeltaTime);
        }
    }
}


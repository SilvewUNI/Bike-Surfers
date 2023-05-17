using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float moveSpeed = 1f;
    public float jumpForce = 1f;
    public float stickiness = 1f;
    public LayerMask stickableSurfaces;

    private Rigidbody rb;
    private bool isGrounded;
    private bool isSticking;
    private Vector3 surfaceNormal;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        // Get input from VR controllers
        float horizontal = Input.GetAxis("VR_Horizontal");
        float vertical = Input.GetAxis("VR_Vertical");
        Vector3 movement = new Vector3(horizontal, 0f, vertical) * moveSpeed * Time.fixedDeltaTime;

        // Rotate movement vector based on VR headset orientation
        movement = Quaternion.Euler(0f, Camera.main.transform.rotation.eulerAngles.y, 0f) * movement;

        if (isSticking) {
            // Apply movement along the surface normal
            Vector3 surfaceTangent = Vector3.Cross(surfaceNormal, Vector3.up).normalized;
            Vector3 stickMovement = Vector3.Cross(surfaceNormal, surfaceTangent) * Vector3.Dot(movement, surfaceTangent) * stickiness;
            rb.MovePosition(transform.position + stickMovement);
        } else {
            // Move player using rigidbody physics
            rb.MovePosition(transform.position + movement);
        }

        if (Input.GetButtonDown("VR_Jump")) {
            if (isGrounded) {
                // Apply vertical impulse based on VR headset orientation
                Vector3 jumpForceVector = Quaternion.Euler(0f, Camera.main.transform.rotation.eulerAngles.y, 0f) * transform.up * jumpForce;
                rb.AddForce(jumpForceVector, ForceMode.Impulse);
                isGrounded = false;
            } else if (isSticking) {
                // Release from the surface
                isSticking = false;
            }
        }
    }

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Ground")) {
            isGrounded = true;
        } else {
            // Check if the surface is stickable
            RaycastHit hit;
            if (Physics.Raycast(transform.position, -other.contacts[0].normal, out hit, 1f, stickableSurfaces)) {
                isSticking = true;
                surfaceNormal = hit.normal;
            }
        }
    }

    void Update() {
        // Update player height and orientation based on VR headset position and rotation
        transform.position = new Vector3(transform.position.x, Camera.main.transform.position.y, transform.position.z);
        transform.rotation = Quaternion.Euler(0f, Camera.main.transform.rotation.eulerAngles.y, 0f);
    }
}

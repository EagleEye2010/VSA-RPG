using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  // SerializeField will allow us to select the rigidbody
  [SerializeField] private Rigidbody rb;
  [SerializeField] private float speed;
  private void Start()
  {
    // Grab component from it, or it won't work
    rb = GetComponent<Rigidbody>();
  }

  private void Update()
  {
    // X and Z velocities
    float x = 0;
    float z = 0;

    // Check if key is down, and then set velocities
    if (Input.GetKey(KeyCode.W)) z = 1;
    else if (Input.GetKey(KeyCode.S)) z = -1;

    if (Input.GetKey(KeyCode.A)) x = -1;
    if (Input.GetKey(KeyCode.D)) x = 1;

    // Multiply by delta time to keep it steady in all frame rates
    x *= Time.deltaTime * speed;
    z *= Time.deltaTime * speed;

    // Move the rigidbody to the position plus the x and z. Keep y the same.
    rb.MovePosition(new Vector3(rb.position.x + x, rb.position.y, rb.position.z + z));
  }
}

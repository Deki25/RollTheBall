using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallJump : MonoBehaviour
{
    Rigidbody rb;

    public float jumpForce = 300f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Jump();
    }

    private void OnMouseDown()
    {
        if (rb.transform.position.y == 1f)
        {
            Vector3 jump = new Vector3(0, jumpForce, 0);
            rb.AddForce(jump);
        }
    }

    private void Jump()
    {
        Vector3 jump = new Vector3(0, jumpForce, 0);
        rb.AddForce(jump);
    }
}

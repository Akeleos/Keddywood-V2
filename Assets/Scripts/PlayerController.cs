using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController current;
    public float moveSpeed;
    public Rigidbody rb;
    private Vector3 moveInput;
    private Vector3 moveVelocity;

    public Animator playerAnimator;
    public Camera mainCamera;
    bool isMoving;
    private void Start()
    {
        current = this;
    }
    void Update()
    {
        Move();
        CameraRay();
    }

    public void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        moveInput = new Vector3(horizontal, 0f, vertical);
        if (moveInput != Vector3.zero)
        {
           
            playerAnimator.SetFloat("Speed", 1);
        }
        else
        {
            playerAnimator.SetFloat("Speed", 0);
        }
        moveVelocity = moveInput * moveSpeed;
    }
    private void CameraRay()
    {
        Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float rayLen;
        if (groundPlane.Raycast(cameraRay, out rayLen))
        {
            Vector3 pointLook = cameraRay.GetPoint(rayLen);
            transform.LookAt(pointLook);
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = moveVelocity;
    }
}

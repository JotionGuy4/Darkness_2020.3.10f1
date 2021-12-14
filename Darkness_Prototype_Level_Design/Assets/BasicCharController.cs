using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCharController : MonoBehaviour
{
    public Camera head;
    public Rigidbody rb;

    public float mouseSpeed;
    public float moveForceMagnitude;

    public float bearing;
    public float pitch;

    private Vector3 moveForceDir;

    public void Start()
    {
        head = GetComponentInChildren<Camera>();
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    public void Update()
    {
        if(Input.GetAxis("Mouse X") != 0)
        {
            bearing += mouseSpeed * Time.deltaTime * Input.GetAxis("Mouse X");
            bearing = (bearing + 360) % 360;
        }
        if (Input.GetAxis("Mouse Y") != 0)
        {
            pitch -= mouseSpeed * Time.deltaTime * Input.GetAxis("Mouse Y");
            pitch = Mathf.Clamp(pitch, -85, 85);
        }

        head.transform.localRotation = Quaternion.Euler(pitch, 0, 0);
        rb.rotation = Quaternion.Euler(0, bearing, 0);

        moveForceDir = Vector3.zero;
        if (Input.GetKey(KeyCode.W)) moveForceDir += transform.forward;
        if (Input.GetKey(KeyCode.S)) moveForceDir -= transform.forward;
        if (Input.GetKey(KeyCode.A)) moveForceDir -= transform.right;
        if (Input.GetKey(KeyCode.D)) moveForceDir += transform.right;
        moveForceDir = moveForceDir.normalized;
    }

    public void FixedUpdate()
    {
        rb.SetMaxAngularVelocity(0);
        rb.AddForce(moveForceDir * moveForceMagnitude, ForceMode.Force);
        rb.AddForce(Vector3.down * 5, ForceMode.Force);
    }

    void OnApplicationFocus(bool ApplicationIsBack)
    {
        if (ApplicationIsBack == true)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}

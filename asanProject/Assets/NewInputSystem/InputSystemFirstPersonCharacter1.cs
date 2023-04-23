//Base code by lukeskt.
//Adapted for asan by Fynn Burgess.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class InputSystemFirstPersonCharacter1 : MonoBehaviour
{
    private InputSystemFirstPersonControls inputActions;


    private Rigidbody rb;
    
    [SerializeField] private Camera cam;
    [SerializeField] private float movementSpeed = 2.0f;
    [SerializeField] public float lookSensitivity = 1.0f;
    
    private float xRotation = 0f;

    // Movement Vars
    private Vector3 velocity;
    public float gravity = -9.81f;
    private bool grounded;
    public int forceX, forceY;

    private void Awake()
    {
        inputActions = new InputSystemFirstPersonControls();
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void Update()
    {
        DoMovement();
        DoLooking();
    }

    private void DoLooking()
    {
        Vector2 looking = GetPlayerLook();
        float lookX = looking.x * lookSensitivity * Time.deltaTime;
        float lookY = looking.y * lookSensitivity * Time.deltaTime;

        xRotation -= lookY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        
        transform.Rotate(Vector3.up * lookX);
    }

    private void DoMovement()
    {
        //grounded = controller.isGrounded;
        if (grounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        Vector2 movement = GetPlayerMovement();
        Vector3 move = transform.right * movement.x + transform.forward * movement.y;
        //controller.Move(move * movementSpeed * Time.deltaTime);
        if (inputActions.FPSController.Move.ReadValue<Vector2>().x >= 0.1f)
        {
        rb.AddForce(transform.up * forceY, ForceMode.Impulse);
        rb.AddForce(transform.forward * forceX, ForceMode.Impulse);
        }
        if (inputActions.FPSController.Move.ReadValue<Vector2>().y >= 0.1f)
        {
            rb.AddForce(transform.up * forceY, ForceMode.Impulse);
            rb.AddForce(transform.right * forceX, ForceMode.Impulse);
        }
        if (inputActions.FPSController.Move.ReadValue<Vector2>().x <= -0.1f)
        {
            rb.AddForce(transform.up * forceY, ForceMode.Impulse);
            rb.AddForce(-transform.right * forceX, ForceMode.Impulse);
        }
        if (inputActions.FPSController.Move.ReadValue<Vector2>().y <= -0.1f)
        {
            rb.AddForce(transform.up * forceY, ForceMode.Impulse);
            rb.AddForce(-transform.forward * forceX, ForceMode.Impulse);
        }
    }
    
    private void OnDisable()
    {
        inputActions.Disable();
    }

    public Vector2 GetPlayerMovement()
    {
        return inputActions.FPSController.Move.ReadValue<Vector2>();
    }

    public Vector2 GetPlayerLook()
    {
        return inputActions.FPSController.Look.ReadValue<Vector2>();
    }
}

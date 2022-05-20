using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

/// <summary>
/// Event for tracking the input of a joystick
/// </summary>
public class OnJoystickMove : MonoBehaviour
{
    public float movementY;
    public float movementX;
    public float speed;

    private Rigidbody rb;

    public GameObject Player;

    [Tooltip("Actions to check")]
    public InputAction action = null;

    [Serializable] public class ValueChangeEvent : UnityEvent<float> { }

    // Called when the x value changes
    public ValueChangeEvent OnXValueChange = new ValueChangeEvent();

    // Called when the y value changes
    public ValueChangeEvent OnYValueChange = new ValueChangeEvent();

    private void Awake()
    {
        action.performed += OnValueChange;
        action.canceled += OnValueChange;
    }

    private void Start()
    {
         rb = Player.GetComponent<Rigidbody>();
    }

    private void OnDestroy()
    {
        action.performed -= OnValueChange;
        action.canceled -= OnValueChange;
    }

    private void OnEnable()
    {
        action.Enable();
    }

    private void OnDisable()
    {
        action.Disable();
    }

    private void OnValueChange(InputAction.CallbackContext context)
    {
        Vector2 value = context.ReadValue<Vector2>();

        movementX = value.x;
        movementY = value.y;

        OnXValueChange.Invoke(value.x);
        OnYValueChange.Invoke(value.y);

    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }


}

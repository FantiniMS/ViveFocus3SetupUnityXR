using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MyInputTest : MonoBehaviour
{

    public InputActionReference moveXAction = null;
    public InputActionReference moveYAction = null;
   
    public Vector2 thumbAxis;

    // Start is called before the first frame update
    private void Awake()
    {
        moveXAction.action.performed += MoveX;
        moveYAction.action.performed += MoveY;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveX(InputAction.CallbackContext context)
    {
        thumbAxis.x = context.ReadValue<float>();
        Debug.Log(thumbAxis);
        Debug.Log("move X: " + context.ReadValue<float>());
    }

    public void MoveY(InputAction.CallbackContext context)
    {
        thumbAxis.y = context.ReadValue<float>();
        Debug.Log(thumbAxis);
        Debug.Log("move Y: " + context.ReadValue<float>());
    }

    public void OnEnable()
    {
        moveXAction.action.Enable();
        moveYAction.action.Enable();
    }

    public void OnDisable()
    {
        moveXAction.action.Disable();
        moveYAction.action.Disable();
    }

}

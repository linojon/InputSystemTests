using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestInputActions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void MyPublicFunction()
    {
        Debug.Log("My public function");
    }

    void OnMyTouchAction(InputValue value)
    {
        Vector2 touchPosition = value.Get<Vector2>();
        Debug.Log("Touch action = " + touchPosition);
    }

    void OnMyMouseClickAction(InputValue value)
    {
        Debug.Log("Mouse click action = " + value.isPressed);
    }

    //void OnPinchAction(InputValue value)
    //{
    //    Vector2 touchPosition = value.Get<Vector2>();
    //    Debug.Log("Pinch action = " + touchPosition);
    //}

    void OnPinchAction()
    {
        Debug.Log("** Pinch Action");
    }
}

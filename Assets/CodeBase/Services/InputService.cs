using UnityEngine;

public class InputService : ISingletone<InputService> 
{
    private Vector3 _inputVector = Vector3.zero;
    private Vector3 _mouseMovement = Vector3.zero;

    public Vector3 MousePosition => Input.mousePosition;

    private static InputService _instance;
    public static InputService Instance => _instance ??= new InputService();

    public Vector3 GetInputVector()
    {
        _inputVector.x = Input.GetAxis("Horizontal");
        _inputVector.z = Input.GetAxis("Vertical");

        return _inputVector;
    }

    public bool GetShootButton() 
        => Input.GetMouseButton(0);

    public bool GetJumpButton()
        => Input.GetKeyDown(KeyCode.Space);

    public Vector3 GetMouseMovement()
    {
        _mouseMovement.y = Input.GetAxis("Mouse X");
        _mouseMovement.x = Input.GetAxis("Mouse Y");

        return _mouseMovement;
    }
}

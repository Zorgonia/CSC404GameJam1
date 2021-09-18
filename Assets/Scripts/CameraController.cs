using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform player;
    public float rotSpeed = 2f;
    public float lowestRotation_angle = 0;
    private float _y_rotation;
    private float _x_rotation;
    private float _HorizontalInput;
    private float _VerticalInput;
    private Vector3 _offset;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        _y_rotation = transform.eulerAngles.y;
        _x_rotation = transform.eulerAngles.x;
        _offset = player.position - transform.position;
    }
    
    void LateUpdate()
    {
        _HorizontalInput = Input.GetAxis("Mouse X");
        _VerticalInput = Input.GetAxis("Mouse Y");
        if (_HorizontalInput != 0)
        {
            _y_rotation += Input.GetAxis("Mouse X") * rotSpeed * 3;
        }
        
        if (_VerticalInput != 0)
        {
            _x_rotation += Input.GetAxis("Mouse Y") * rotSpeed * 3;
        }

        _x_rotation = Mathf.Clamp(_x_rotation, lowestRotation_angle, 90);
        Quaternion rotation = Quaternion.Euler(_x_rotation, _y_rotation, 0);
        transform.position = player.position - (rotation * _offset);
        transform.LookAt(player);
    }
}

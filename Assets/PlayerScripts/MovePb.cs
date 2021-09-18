using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePb : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Transform _transform;

    private float _playerInput;
    private float _turningInput;

    public const float MovementScale = 3.0f;
    public const float TurningScale = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        _playerInput = Input.GetAxis("Vertical");
        _turningInput = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = _transform.TransformVector(_turningInput * TurningScale, 0,
            _playerInput * MovementScale);
    }
}

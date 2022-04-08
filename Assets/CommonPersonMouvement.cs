using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonPersonMouvement : MonoBehaviour
{

    [SerializeField] private CharacterController _controller;
    [SerializeField] private float _jumpForce;

    //Gravity Variable
    private Vector3 velocity;
    [SerializeField] private float _gravity;
    [SerializeField] Transform _groundCheck;
    private float _groundDistance = 0.4f;
    [SerializeField] private LayerMask _groundMask;
    private bool _isGrounded;


    // Update is called once per frame
    void Update()
    {
        _isGrounded = Physics.CheckSphere(_groundCheck.position, _groundDistance, _groundMask);
        if (_isGrounded && velocity.y < 0)
            velocity.y = -2f;

        //Jump
        if (Input.GetButtonDown("Jump") && _isGrounded)
        {
            velocity.y = Mathf.Sqrt(_jumpForce * -2 * _gravity);
        }

        //Gravity
        velocity.y += _gravity * Time.deltaTime;
        _controller.Move(velocity * Time.deltaTime);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmissiveToGravity : MonoBehaviour
{
    private Rigidbody _rb;
    private float _gravityForce;

    private void OnEnable()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.useGravity = false;
    }

    private void FixedUpdate()
    {
        _gravityForce = GravityRoom.GravityForce;

        if (_gravityForce != 0)
        {
            _rb.velocity = Vector3.up * _gravityForce;
        }
    }

    private void OnDisable()
    {
        _rb.useGravity = true;
    }
}
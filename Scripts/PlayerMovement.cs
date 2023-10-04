using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController characterController;

    [SerializeField] private float speed = 2;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    public void MoveToDirection(Vector3 direction)
    {
        // To make player to see the direction it's ahead
        float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);

        // Move player
        characterController.Move(direction * speed * Time.deltaTime);
    }
}

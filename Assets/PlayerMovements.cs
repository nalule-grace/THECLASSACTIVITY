using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovements : MonoBehaviour
{
    public InputActionProperty moveInput; // Assign LeftHand Move action
    public float speed = 2.0f;
    private CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector2 input = moveInput.action.ReadValue<Vector2>(); // Read joystick input
        Vector3 move = new Vector3(input.x, 0, input.y);
        characterController.Move(transform.TransformDirection(move) * speed * Time.deltaTime);
    }
}


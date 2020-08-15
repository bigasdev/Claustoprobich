using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Controller controller;

    [SerializeField] private float runSpeed = 40f;
    float horizontalMove = 0f;

    bool jump;

    private void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * runSpeed;

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;
    }
}

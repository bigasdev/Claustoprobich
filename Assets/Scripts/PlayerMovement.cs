using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Controller controller;
    [SerializeField] private Animator anim;
    [SerializeField] private bool onWater;
    [SerializeField] private float runSpeed = 40f;

    [SerializeField] private Rigidbody2D rb;
    float horizontalMove = 0f;

    bool jump;

    private void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            anim.SetTrigger("Jump");
            StartCoroutine(realJump());
        }

        if(onWater)
        {
            runSpeed = 10f;
            anim.SetBool("Drowning", true);
        }
        else
        {
            runSpeed = runSpeed;
        }

    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("Running", true);
        }
        else if(onWater)
        {
            anim.SetBool("Running", false);
            rb.velocity = new Vector2(0, .5f);
        }
        else
        {
            anim.SetBool("Running", false);
        }
        

    }

    IEnumerator realJump()
    {
        yield return new WaitForSeconds(.15f);
        jump = true;
    }

    public void land()
    {
        anim.SetTrigger("Fall");
    }
}

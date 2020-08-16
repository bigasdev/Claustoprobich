using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpLimiter : MonoBehaviour
{
    [SerializeField] private Controller pm;
    [SerializeField] private float jumpForce;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            pm.m_JumpForce = jumpForce;
        }
    }
}

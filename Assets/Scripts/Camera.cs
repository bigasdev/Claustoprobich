using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float smoothSpd = .125f;

    void Update()
    {
        lateCamera();
    }

    private void lateCamera()
    {
        Vector3 desiredPosition = transform.position;
        desiredPosition.x = (player.position + offset).x;
        desiredPosition.y = (player.position + offset).y;
        transform.position = desiredPosition;

    }
}

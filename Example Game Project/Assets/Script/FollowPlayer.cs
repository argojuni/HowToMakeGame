using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float smoothSpeed=0.125f;
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothPosition;

        transform.LookAt(player);
        FindObjectOfType<PlayerMovement>(transform);
    }
}

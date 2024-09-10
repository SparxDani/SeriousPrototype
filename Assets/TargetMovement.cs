using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    public enum MovementDirection { Horizontal, Vertical }
    public MovementDirection movementDirection = MovementDirection.Horizontal;

    public float speed = 2f;
    public float distance = 5f;

    private Vector3 startingPosition;

    void Start()
    {
        startingPosition = transform.position;
    }

    void Update()
    {
        if (movementDirection == MovementDirection.Horizontal)
        {
            // Movimiento horizontal
            transform.position = new Vector3(startingPosition.x + Mathf.PingPong(Time.time * speed, distance), startingPosition.y, startingPosition.z);
        }
        else if (movementDirection == MovementDirection.Vertical)
        {
            // Movimiento vertical
            transform.position = new Vector3(startingPosition.x, startingPosition.y + Mathf.PingPong(Time.time * speed, distance), startingPosition.z);
        }
    }
}

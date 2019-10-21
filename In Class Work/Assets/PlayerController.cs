using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float gravity;
    public float jumpHeight;

    public LayerMask Floor;
    public Transform feet;

    private Vector3 direction;
    private Vector3 walkingVelocity;
    private Vector3 fallingVelocity;

    private CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5.0f;
        gravity = 9.8f;
        jumpHeight = 2.5f;
        direction = Vector3.zero;
        fallingVelocity = Vector3.zero;
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        direction = direction.normalized;
        walkingVelocity = direction * speed;

    }
}

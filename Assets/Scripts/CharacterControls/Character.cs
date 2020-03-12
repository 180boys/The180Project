//Script by Evan Waters: 1017144
//T120

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    //Set camera to focus on player here
    [Header("Cameras")]
    public Camera mainCamera;

    //Setting physics and movement speed
    [Header("Physics and Movement Speed")]
    public Rigidbody playerRigidbody;
    public float speed = 4f;

    [Header("Movement")]
    public Vector3 inputDirection;
    public Vector3 movement;

    [Header("Rotation")]
    public Plane playerMovementPlane;
    private RaycastHit floorRaycastHit;
    public Vector3 playerToMouse;

    [Header("Animation")]
    public Animator playerAnimator;

    //inputs
    Vector2 movementInput;
    Vector2 lookPosition;

   // PlayerInputActions inputAction;


    void Awake()
    {
       /* CreatePlayerMovementPlane();
        inputAction = new PlayerInputActions();
        inputAction.PlayerControls.Move.performed += ctx => movementInput = ctx.ReadValue<Vector2>();
        inputAction.PlayerControls.FireDirection.performed += ctx => lookPosition = ctx.ReadValue<Vector2>();
    */
    }

}

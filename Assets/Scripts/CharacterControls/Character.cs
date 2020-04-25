//Script by Evan: 1017144
//T120

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    //Set camera to focus on player here
    [Header("Camera")]
    public Camera mainCamera;

    //Setting physics and movement speed
    [Header("Physics and Movement Speed")]
    public Rigidbody playerRigidbody;
    public float speed;
    private Vector3 inputDirection;
    private Vector3 movement;

    [Header("Health")]
    public float Health;

    [Header("Bullet")]
    public Rigidbody Bullet;
    public Transform BulletEmitter;
    public float Firerate = 0.3f;
    public float Timer = 1f;
    public bool bulletTime = false;
    public float bulletTimer = 10f;

    [Header("SFX")]
    public AudioSource Hit;
    public AudioSource Bang;
    //public AudioSource Walk; //NOTE: use for later maybe. walk sfx bugs

    private Plane playerMovementPlane;
    private RaycastHit floorRaycastHit;
    private Vector3 playerToMouse;

    [Header("Animation")]
    //public Animator playerAnimator;

    //inputs
    Vector2 movementInput;
    Vector2 lookPosition;

    PlayerInputActions inputAction;


    void Awake()
    {
        CreatePlayerMovementPlane();
        inputAction = new PlayerInputActions();
        inputAction.PlayerControls.move.performed += ctx => movementInput = ctx.ReadValue<Vector2>();
        inputAction.PlayerControls.look.performed += ctx => lookPosition = ctx.ReadValue<Vector2>();

    }

    void CreatePlayerMovementPlane()
    {
        playerMovementPlane = new Plane(transform.up, transform.position + transform.up);
    }

    void FixedUpdate()
    {

        float h = movementInput.x;
        float v = movementInput.y;

        var targetInput = new Vector3(h, 0, v);
        inputDirection = Vector3.Lerp(inputDirection, targetInput, Time.deltaTime * 10f);

        //Camera Direction
        var cameraForward = mainCamera.transform.forward;
        var cameraRight = mainCamera.transform.right;

        cameraForward.y = 0f;
        cameraRight.y = 0f;

        Vector3 desiredDirection = cameraForward * inputDirection.z + cameraRight * inputDirection.x;

        //Move and turn
        MoveThePlayer(desiredDirection);
        TurnThePlayer();
        //AnimateThePlayer(desiredDirection);

        Debug.Log("Camera move" + cameraForward);
    }

    void MoveThePlayer(Vector3 desiredDirection)
    {
        //Walk.Play();
        movement.Set(desiredDirection.x, 0f, desiredDirection.z);

        movement = movement * speed * Time.deltaTime;

        playerRigidbody.MovePosition(transform.position + movement);

    }
    Vector3 PlaneRayIntersection(Plane plane, Ray ray)
    {
        float dist = 0.0f;
        plane.Raycast(ray, out dist);
        return ray.GetPoint(dist);
    }

    Vector3 ScreenPointToWorldPointOnPlane(Vector3 screenPoint, Plane plane, Camera camera)
    {
        Ray ray = camera.ScreenPointToRay(screenPoint);
        return PlaneRayIntersection(plane, ray);
    }

    void TurnThePlayer()
    {
        Vector2 input = lookPosition;

        // Convert "input" to a Vector3 where the Y axis will be used as the Z axis
        Vector3 lookDirection = new Vector3(input.x, 0, input.y);
        var lookRot = mainCamera.transform.TransformDirection(lookDirection);
        lookRot = Vector3.ProjectOnPlane(lookRot, Vector3.up);

        if (lookRot != Vector3.zero)
        {
            Quaternion newRotation = Quaternion.LookRotation(lookRot);
            playerRigidbody.MoveRotation(newRotation);
            Invoke("Shoot", Firerate);
        }
    }

    private void Update()
    {
        //bulletTimer
        if (bulletTime == true)
        {
                bulletTimer -= Time.deltaTime;
        }

        //bullettime cont
        //resetting
        if (bulletTimer <= 0)
        {
            bulletTime = false;
            Firerate = 0.3f;
            bulletTimer = 10f;

        }

        Timer -= Time.deltaTime;

        if (Health <= 0)
        {
            Invoke("GameOver", 0.1f);
        }
    }

    public void GameOver()
    {     
        SceneManager.LoadScene("GameOver", LoadSceneMode.Single); 
    }

    public void OnCollisionEnter(Collision collision)
    {
        //ai bullet
        if (collision.gameObject.tag == "AIBullet")
        {
            Debug.Log("get hit");
            Hit.Play();
            Health -= 10;
        }
        //bullettime
        if (collision.gameObject.tag == "BulletPickup")
        {
            Debug.Log("weapon speed");
            Destroy(collision.gameObject);
            Firerate = 0.6f;
            bulletTime = true;
        }
        
    }

    void Shoot()
    {
        if(Timer <= 0.5)
        {
            Bang.Play();
            Rigidbody instance = Instantiate(Bullet, BulletEmitter.position, BulletEmitter.rotation);
            instance.velocity = BulletEmitter.up * 12;
            Timer = 1f;
        }
        
    }

    /* void AnimateThePlayer(Vector3 desiredDirection)
    {
        if (!playerAnimator)
            return;

        Vector3 movement = new Vector3(desiredDirection.x, 0f, desiredDirection.z);
        float forw = Vector3.Dot(movement, transform.forward);
        float stra = Vector3.Dot(movement, transform.right);

        playerAnimator.SetFloat("Forward", forw);
        playerAnimator.SetFloat("Strafe", stra);
    } */

    //on and off checking
    private void OnEnable()
    {
        inputAction.Enable();
    }

    private void OnDisable()
    {
        inputAction.Disable();
        CancelInvoke("Shoot");
    }
}


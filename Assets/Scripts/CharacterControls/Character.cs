//Script by Evan: 1017144
//T120

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    //Set camera to focus on player here
    [Header("Camera")]
    public Camera mainCamera;
    [Space]

    //Setting physics and movement speed
    [Header("Physics and Movement Speed")]
    public Rigidbody playerRigidbody;
    public float speed = 6f;
    public bool movementTime;
    public float movementTimer;
    private Vector3 inputDirection;
    private Vector3 movement;
    [Space]

    [Header("HP")]
    public float Health;
    [Space]

    [Header("Bullet")]
    public Rigidbody Bullet;
    public Transform BulletEmitter;
    public float Firerate = 0.3f;
    public float Timer = 1f;
    [Space]

    [Header("BulletPickup")]
    public bool bulletTime = false;
    public float bulletTimer = 10f;
    public float BulletSpeed = 12f;
    [Space]

    [Header("SFX")]
    public AudioSource Hit;
    public AudioSource Shooting;
    public AudioSource HealthUp;
    public AudioSource BulletUp;
    public AudioSource MoveUp;

    private Plane playerMovementPlane;
    private RaycastHit floorRaycastHit;
    private Vector3 playerToMouse;

    [Header("Animation")]
    public Animator playerAnimator;

    [Header("HUD Links")]
    public Image HPBar;
    public Image MovementBar;
    public Image ShootBar;
    public Image EnemyBar;

    public float EnemyCounter;

    [Header("Boss goes here")]
    public GameObject BossMan;
    public GameObject BossBar;
    public GameObject BossBG;
    public GameObject EneBar;
    public GameObject EneBG;

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

            //shooting
            Invoke("Shoot", Firerate);

        }
    }

    private void Update()
    {
        EnemyCounter = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if (EnemyCounter == 0)
        {
            BossTrigger();
        }

        //Counter bar
        EnemyBar.fillAmount = EnemyCounter / 20;

        //HP bar
        HPBar.fillAmount = Health / 100;

        //bulletTimer
        if (bulletTime == true)
        {
            bulletTimer -= Time.deltaTime;
            //bulletTimer converted to bar
            ShootBar.fillAmount = bulletTimer / 10;
        }

        //bullet
        //resetting
        if (bulletTimer <= 0)
        {
            bulletTime = false;
            BulletSpeed = 25;
            bulletTimer = 10f;
            ShootBar.fillAmount = 0;
        }

        //movementTimer
        if (movementTime == true)
        {
            movementTimer -= Time.deltaTime;
            //muvetimer converted to bar
            MovementBar.fillAmount = movementTimer / 6;
        }

        //movement
        //resetting
        if (movementTimer <= 0)
        {
            movementTime = false;
            gameObject.GetComponent<TrailRenderer>().enabled = false;
            speed = 6;
            movementTimer = 6f;
        }

        //Shoot timer
        Timer -= Time.deltaTime;

        //dead. sends to death scene
        if (Health <= 0)
        {
            Invoke("GameOver", 0.1f);
        }

        //sets health back to 100, if you gain more than 101
        if (Health >= 101)
        {
            Health = 100;
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
        //bullettime pickup
        //buffs are set here
        if (collision.gameObject.tag == "BulletPickup")
        {
            Debug.Log("weapon speed");
            Destroy(collision.gameObject);
            BulletUp.Play();
            BulletSpeed = 50f;
            bulletTime = true;
        }

        //walkingspeed pickup
        //buffs are set here
        if (collision.gameObject.tag == "MovementPickup")
        {
            Debug.Log("move speed");
            Destroy(collision.gameObject);
            MoveUp.Play();
            gameObject.GetComponent<TrailRenderer>().enabled = true;
            speed = 12f;
            movementTime = true;

        }

        //healthpickup. basic, just have to add 20hp
        if (collision.gameObject.tag == "HealthPickup")
        {
            Debug.Log("+20");
            Destroy(collision.gameObject);
            HealthUp.Play();
            Health += 20;

        }

    }

    void BossTrigger()
    {
        BossMan.SetActive(true);
        BossBar.SetActive(true);
        BossBG.SetActive(true);
        EneBar.SetActive(false);
        EneBG.SetActive(false);
    }

    void Shoot()
    {
        if (Timer <= 0.5)
        {
            Shooting.Play();
            Rigidbody instance = Instantiate(Bullet, BulletEmitter.position, BulletEmitter.rotation);
            instance.velocity = BulletEmitter.up * BulletSpeed;
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
    public void OnEnable()
    {
        inputAction.Enable();

        //animations for running
        playerAnimator.SetBool("IsRunning", true);
        playerAnimator.SetBool("IsIdle", false);
    }

    public void OnDisable()
    {
        inputAction.Disable();

        //idle animations
        playerAnimator.SetBool("IsRunning", false);
        playerAnimator.SetBool("IsIdle", true);

        CancelInvoke("Shoot");
    }

}


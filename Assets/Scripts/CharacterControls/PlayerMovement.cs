using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int playerno;
    public bool shoot;
    public bool walking;
    public float moveSpeed;
    public bool turning;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playerno == 1)
        {
            //get the Input from Horizontal axis
            float horizontalInput = Input.GetAxis("Horizontal");
            //get the Input from Vertical axis
            float verticalInput = Input.GetAxis("Vertical");

            //update the position
            transform.position = transform.position + new Vector3(verticalInput * moveSpeed * Time.deltaTime, 0f, -horizontalInput * moveSpeed * Time.deltaTime);

            if (horizontalInput > 0.1f || horizontalInput < -0.1f || verticalInput > 0.1f || verticalInput < -0.1f)
            {
                walking = true;
            }
            else
            {
                walking = false;
            }


            //get the Input from Horizontal axis
            float righthorizontalInput = Input.GetAxis("RightHorizontal");
            //get the Input from Vertical axis
            float rightverticalInput = Input.GetAxis("RightVertical");

            if (righthorizontalInput > 0.1f || righthorizontalInput < -0.1f || rightverticalInput > 0.1f || rightverticalInput < -0.1f)
            {
                turning = true;
            }
            else
            {
                turning = false;
            }

            if (turning)
            {
                //update the position
                Vector3 rlookDirection = new Vector3(righthorizontalInput, 0, -rightverticalInput);
                transform.rotation = Quaternion.LookRotation(rlookDirection);
            }
        }

            if (playerno == 2)
            {
                //get the Input from Horizontal axis
                float horizontalInput = Input.GetAxis("Horizontal1");
                //get the Input from Vertical axis
                float verticalInput = Input.GetAxis("Vertical1");

                //update the position
                transform.position = transform.position + new Vector3(verticalInput * moveSpeed * Time.deltaTime, 0f, -horizontalInput * moveSpeed * Time.deltaTime);

                if (horizontalInput > 0.1f || horizontalInput < -0.1f || verticalInput > 0.1f || verticalInput < -0.1f)
                {
                    walking = true;
                }
                else
                {
                    walking = false;
                }


                //get the Input from Horizontal axis
                float righthorizontalInput = Input.GetAxis("RightHorizontal1");
                //get the Input from Vertical axis
                float rightverticalInput = Input.GetAxis("RightVertical1");

                if (righthorizontalInput > 0.1f || righthorizontalInput < -0.1f || rightverticalInput > 0.1f || rightverticalInput < -0.1f)
                {
                    turning = true;
                }
                else
                {
                    turning = false;
                }

                if (turning)
                {
                    //update the position
                    Vector3 rlookDirection = new Vector3(-rightverticalInput, 0,  righthorizontalInput);
                    transform.rotation = Quaternion.LookRotation(rlookDirection);
                }
            }

    }
}

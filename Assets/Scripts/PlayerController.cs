using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqeForce = 3f;
    [SerializeField] float baseSpeed = 20f;
    [SerializeField] float boostSpeed = 30f;

    bool canMove = true;
    Rigidbody2D playerRB2d;
    SurfaceEffector2D surfaceEffector2d;

    // Start is called before the first frame update
    void Start()
    {
        playerRB2d = GetComponent<Rigidbody2D>();
        surfaceEffector2d = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            RespondToBoost();
        }
    }

    public void DisableControls()
    {
        canMove = false;
    }

    void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2d.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2d.speed = baseSpeed;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRB2d.AddTorque(torqeForce);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRB2d.AddTorque(-torqeForce);
        }
    }
}

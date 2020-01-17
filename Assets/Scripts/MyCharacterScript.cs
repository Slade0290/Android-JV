﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterScript : MonoBehaviour
{
    protected Joystick joystick;

    protected ActionButtonScript joybuttonA;

    protected SpecialButtonScript joybuttonS;

    protected bool action;
    protected bool special;

    [SerializeField]
    private float rotationSpeed = 5;

    [SerializeField]
    private Transform spawnAera;

    private GameObject player;

    private float joystickH;
    private float joystickV;

    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joybuttonA = FindObjectOfType<ActionButtonScript>();
        joybuttonS = FindObjectOfType<SpecialButtonScript>();

        transform.position = spawnAera.position;
        player = GameObject.FindGameObjectWithTag("Player");
        joystickH = joystick.Horizontal;
        joystickV = joystick.Vertical;
    }

    public void Action()
    {
        Debug.Log("bla bla bla touch button");
    }

    // Update is called once per frame
    void Update()
    {
        var rigibody = GetComponent<Rigidbody>();
        rigibody.velocity = new Vector3(joystick.Horizontal * 10f, rigibody.velocity.y, joystick.Vertical * 10f);

        if (!action && joybuttonA.Pressed)
        {
            Debug.Log("joybuttonA");
            action = true;
        }
        if (action && !joybuttonA.Pressed)
        {
            action = false;
        }
        if (!special && joybuttonS.Pressed)
        {
            Debug.Log("joybuttonS");
            special = true;
        }
        if (special && !joybuttonS.Pressed)
        {
            special = false;
        }

        //Character rotation
        float inputZ = joystick.Horizontal;
        float inputX = -joystick.Vertical;
        if (!(joystickH == inputX && joystickV == inputZ))
        {
            Vector3 lookDirection = new Vector3(inputX, 0, inputZ);
            Debug.Log("lookDirection : " + lookDirection);
            Debug.Log("player.transform.rotation : " + player.transform.rotation);
            Quaternion lookRotation = Quaternion.LookRotation(lookDirection, Vector3.up);

            float step = rotationSpeed * Time.deltaTime;
            player.transform.rotation = Quaternion.RotateTowards(lookRotation, transform.rotation, step);
        }
    }
}

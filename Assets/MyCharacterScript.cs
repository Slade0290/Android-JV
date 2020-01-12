using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterScript : MonoBehaviour
{
    protected Joystick joystick;

    protected ActionButtonScript joybutton;

    protected bool action;

    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<ActionButtonScript>();
    }

    // Update is called once per frame
    void Update()
    {
        var rigibody = GetComponent<Rigidbody>();

        rigibody.velocity = new Vector3(joystick.Horizontal * 100f, rigibody.velocity.y, joystick.Vertical * 100f);
        if(!action && joybutton.Pressed)
        {
            Debug.Log("joybutton");
            action = true;
        }
        if(action && !joybutton.Pressed)
        {
            action = false;
        }
    }
}

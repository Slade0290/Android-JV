using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterScript : MonoBehaviour
{
    [SerializeField]
    protected Joystick joystick;

    [SerializeField]
    protected ActionButtonScript joybutton;

    [SerializeField]
    private float Speed;

    protected bool action;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var rigibody = GetComponent<Rigidbody>();

        rigibody.velocity = new Vector3(joystick.Horizontal * Speed, rigibody.velocity.y, joystick.Vertical * Speed);
        Debug.Log(rigibody.velocity);
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

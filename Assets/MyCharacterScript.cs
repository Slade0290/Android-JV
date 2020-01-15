using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterScript : MonoBehaviour
{
    [SerializeField]
    protected Joystick joystick;

    protected ActionButtonScript joybuttonA;

    protected SpecialButtonScript joybuttonS;

    [SerializeField]
    private float Speed;

    protected bool action;
    protected bool special;

    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joybuttonA = FindObjectOfType<ActionButtonScript>();
        joybuttonS = FindObjectOfType<SpecialButtonScript>();
    }

    // Update is called once per frame
    void Update()
    {
        var rigibody = GetComponent<Rigidbody>();

        rigibody.velocity = new Vector3(joystick.Horizontal * 100f, rigibody.velocity.y, joystick.Vertical * 100f);
        
        if(!action && joybuttonA.Pressed)
        {
            Debug.Log("joybuttonA");
            action = true;
        }
        if(action && !joybuttonA.Pressed)
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
    }
}

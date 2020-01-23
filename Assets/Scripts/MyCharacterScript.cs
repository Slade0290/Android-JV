using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterScript : MonoBehaviour
{
    private Animator Anim;

    [SerializeField]
    private GameObject PlayerTShirt1, PlayerTShirt2, PlayerTShirt3;

    [SerializeField]
    private GameObject PlayerPants1, PlayerPants2;

    [SerializeField]
    private GameObject PlayerShoes1, PlayerShoes2;

    protected Joystick joystick;

    protected ActionButtonScript joybuttonA;

    //protected SpecialButtonScript joybuttonS;

    protected bool action;
    protected bool special;

    [SerializeField]
    private float rotationSpeed = 5;

    [SerializeField]
    private Transform spawnAera;

    private GameObject player;

    private float joystickH;
    private float joystickV;

    private Rigidbody r;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerTShirt1 != null)
        {
            PlayerTShirt1.GetComponent<Renderer>().material.color = hexToColor(CharacterColorPref.tshirtColor);
            PlayerTShirt2.GetComponent<Renderer>().material.color = hexToColor(CharacterColorPref.tshirtColor);
            PlayerTShirt3.GetComponent<Renderer>().material.color = hexToColor(CharacterColorPref.tshirtColor);

            PlayerPants1.GetComponent<Renderer>().material.color = hexToColor(CharacterColorPref.pantsColor);
            PlayerPants2.GetComponent<Renderer>().material.color = hexToColor(CharacterColorPref.pantsColor);

            PlayerShoes1.GetComponent<Renderer>().material.color = hexToColor(CharacterColorPref.shoesColor);
            PlayerShoes2.GetComponent<Renderer>().material.color = hexToColor(CharacterColorPref.shoesColor);
        }

        joystick = FindObjectOfType<Joystick>();
        joybuttonA = FindObjectOfType<ActionButtonScript>();
        //joybuttonS = FindObjectOfType<SpecialButtonScript>();

        transform.position = spawnAera.position;
        player = GameObject.FindGameObjectWithTag("Player");
        joystickH = joystick.Horizontal;
        joystickV = joystick.Vertical;

        Anim = GetComponent<Animator>();
        r = GetComponent<Rigidbody>();

    }

    public static Color hexToColor(string hex)
    {
        return new Color32(byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber),
                            byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber),
                            byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber),
                            255);
    }

    public void Action()
    {
        Debug.Log("bla bla bla touch button");
    }

    // Update is called once per frame
    void Update()
    {
        if(r != null)
        {
            r.velocity = new Vector3(joystick.Horizontal * 10f, r.velocity.y, joystick.Vertical * 10f);
        }


        if (!action && joybuttonA.Pressed)
        {
            Debug.Log("joybuttonA");
            action = true;
        }
        if (action && !joybuttonA.Pressed)
        {
            action = false;
        }
        /*
        if (!special && joybuttonS.Pressed)
        {
            Debug.Log("joybuttonS");
            special = true;
        }
        if (special && !joybuttonS.Pressed)
        {
            special = false;
        }
        */

        //Character rotation
        float inputZ = joystick.Horizontal;
        float inputX = -joystick.Vertical;
        if (!(joystickH == inputX && joystickV == inputZ))
        {
            Vector3 lookDirection = new Vector3(inputX, 0, inputZ);
            //Debug.Log("lookDirection : " + lookDirection);
            //Debug.Log("player.transform.rotation : " + player.transform.rotation);
            Quaternion lookRotation = Quaternion.LookRotation(lookDirection, Vector3.up);

            float step = rotationSpeed * Time.deltaTime;
            player.transform.rotation = Quaternion.RotateTowards(lookRotation, transform.rotation, step);
            Anim.Play("Walk");
        }
        else
        {
            Anim.Play("Idle");
        }
    }
}

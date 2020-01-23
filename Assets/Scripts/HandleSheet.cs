using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleSheet : MonoBehaviour
{
    private Animator Anim;

    [SerializeField]
    private GameObject ButtonA;

    private bool canOpen = false;

    private bool isOpen = false;

    private bool Pressed;

    private void Start()
    {
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canOpen)
        {
            if (ButtonA != null)
            {
                Pressed = ButtonA.GetComponent<ActionButtonScript>().Pressed;
                if (isOpen && Pressed)
                {
                    Anim.Play("CloseSheet");
                    isOpen = false;

                }
                else if (!isOpen && Pressed)
                {
                    Anim.Play("OpenSheet");
                    isOpen = true;
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        canOpen = true;
    }

    private void OnTriggerExit(Collider other)
    {
        canOpen = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleSheet : MonoBehaviour
{
    private Animator Anim;

    private ActionButtonScript ButtonA;

    private bool canOpen = false;

    private bool isOpen = false;

    private void Start()
    {
        ButtonA = GetComponent<ActionButtonScript>();
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canOpen)
        {
            if (isOpen && (ButtonA.Pressed == true))
            {
                Debug.Log("fermeture");
                Anim.Play("CloseSheet");
                isOpen = false;

            }else if(!isOpen && (ButtonA.Pressed == true))
            {
                Debug.Log("ouverture");
                Anim.Play("OpenSheet");
                isOpen = true;
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

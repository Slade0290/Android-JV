using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFense : MonoBehaviour
{
    private int NbColliderInTrigger;

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(NbColliderInTrigger > 0)
        {
            anim.Play("OpenFense");
        }
        else
        {
            anim.Play("CloseFense");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        NbColliderInTrigger++;
        Debug.Log(other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        NbColliderInTrigger--;
    }
}

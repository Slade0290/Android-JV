using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StealScript : MonoBehaviour
{
    [SerializeField]
    private GameObject ButtonA;

    private bool canSteal = false;

    private bool Pressed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ButtonA != null)
        {
            Pressed = ButtonA.GetComponent<ActionButtonScript>().Pressed;
            //Debug.Log(Pressed);
            if (canSteal && Pressed)
            {
                CharacterColorPref.score += 50;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if(other.gameObject.tag == "Player")
        {
            canSteal = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            canSteal = false;
    }
}

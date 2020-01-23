using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StealScript : MonoBehaviour
{
    [SerializeField]
    private GameObject ButtonA;

    private bool canSteal = false;

    private bool hasSteal = false;

    private bool Pressed;

    private Transform[] Childrens;

    private Component Items;

    // Start is called before the first frame update
    void Start()
    {
        Childrens = GetComponentsInChildren<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ButtonA != null)
        {
            Pressed = ButtonA.GetComponent<ActionButtonScript>().Pressed;
            if (canSteal && Pressed && !hasSteal)
            {
                if (Childrens != null)
                {
                    foreach (var Children in Childrens)
                    {
                        if (Children.tag == "Items")
                        {
                            Children.localScale = new Vector3(0, 0, 0);
                            hasSteal = true;
                        }
                    }
                }
                CharacterColorPref.score += 50;
                Pressed = false;

            }
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Player")
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

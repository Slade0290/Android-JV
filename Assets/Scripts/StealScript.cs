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
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ButtonA != null)
        {
            Pressed = ButtonA.GetComponent<ActionButtonScript>().Pressed;
            if (canSteal && Pressed)
            {
                Debug.Log("stole");
                CharacterColorPref.score += 50;
                hasSteal = true;
                Pressed = false;
            }
        }

        if (hasSteal)
        {
            //Items = FindComponentInChildWithTag<Component>(gameObject, "Items");

            //Items.gameObject.SetActive(false);

            Childrens = GetComponentsInChildren<Transform>();
            if(Childrens != null)
            {
                foreach (var Children in Childrens)
                {
                    if (Children.tag == "Items")
                    {
                        Children.localScale = new Vector3(0, 0, 0);
                    }
                }
            }
        }
    }

    /*public Component FindComponentInChildWithTag(this GameObject parent, string tag)
    {
        Transform t = parent.transform;
        foreach (Transform tr in t)
        {
            if (tr.tag == tag)
            {
                return tr.GetComponent();
            }
        }
        return default;
    }*/

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

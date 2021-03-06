﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class VoleurButtonScript : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{

    public bool Pressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
        Pressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("OnPointerUp");
        Pressed = false;
        CharacterColorPref.chosenSide = "Voleur";
        SceneManager.LoadScene("ChooseLevel");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

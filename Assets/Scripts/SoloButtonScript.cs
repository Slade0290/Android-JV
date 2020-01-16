using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoloButtonScript : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{

    public bool Pressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
    }

{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}

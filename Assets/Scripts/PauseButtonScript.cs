using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PauseButtonScript : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{

    public bool Pressed;
    protected GameObject menuCanvas;
    protected GameObject subMenuCanvas;

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
        Pressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("OnPointerUp");
        Pressed = false;
        Time.timeScale = 0; // No more update
        subMenuCanvas.SetActive(true);
        menuCanvas.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        menuCanvas = GameObject.FindGameObjectWithTag("MenuCanvas");
        subMenuCanvas = GameObject.FindGameObjectWithTag("SubMenuCanvas");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

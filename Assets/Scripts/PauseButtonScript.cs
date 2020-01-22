using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PauseButtonScript : MonoBehaviour//, IPointerUpHandler, IPointerDownHandler
{

    public bool Pressed;
    
    [SerializeField]
    private GameObject menuCanvas;
    
    [SerializeField]
    private GameObject subMenuCanvas;

    public void gamePause()
    {
        Pressed = false;
        Time.timeScale = 0; // No more update
        subMenuCanvas.SetActive(true);
        menuCanvas.SetActive(false);
    }

    public void gameUnpause()
    {
        Pressed = false;
        Time.timeScale = 1;
        subMenuCanvas.SetActive(!true);
        menuCanvas.SetActive(!false);
    }

}

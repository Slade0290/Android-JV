using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void ChangeSceneToSuperMarket()
    {
        Debug.Log("Pressed");
        SceneManager.LoadScene("superMarket");
    }


}

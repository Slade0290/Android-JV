using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void ChangeSceneToSuperMarket(int level)
    {
        Debug.Log("Pressed");
        CharacterColorPref.chosenLevel = level;
        SceneManager.LoadScene("Loading");
    }

    public void ChangeSceneToMenu()
    {
        SceneManager.LoadScene("Menu");
    }


}

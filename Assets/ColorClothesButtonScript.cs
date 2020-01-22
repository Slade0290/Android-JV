using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColorClothesButtonScript : MonoBehaviour
{
    [SerializeField]
    private GameObject PlayerTShirt1, PlayerTShirt2, PlayerTShirt3;
    
    [SerializeField]
    private GameObject PlayerPants1, PlayerPants2;
    
    [SerializeField]
    private GameObject PlayerShoes1, PlayerShoes2;

    [SerializeField]
    private GameObject MainCanvasButton;

    [SerializeField]
    private GameObject CanvasColorButton;

    private static bool TShirts, Pants, Shoes;    


    // CANVAS
    public void triggerMainCanvasButton(bool val)
    {
        MainCanvasButton.SetActive(val);
    }

    public void triggerCanvasColor(bool val)
    {
        CanvasColorButton.SetActive(val);
    }

    // BUTTONS
    public void changeTShirtsColor()
    {
        triggerMainCanvasButton(false);
        triggerCanvasColor(true);
        TShirts = true;
    }

    public void changePantsColor()
    {
        triggerMainCanvasButton(false);
        triggerCanvasColor(true);
        Pants = true;
    } 

    public void changeShoesColor()
    {
        triggerMainCanvasButton(false);
        triggerCanvasColor(true);
        Shoes = true;
    }

    public void closeColorButton()
    {
        triggerCanvasColor(!true);
        triggerMainCanvasButton(!false);
        TShirts = false;
        Pants = false;
        Shoes = false;
    }

    public void backButton()
    {
        Debug.Log("Ta grand mere");
        SceneManager.LoadScene("Menu");
    }

    // COLORS BUTTONS

    public void ColorButton(string color)
    {
        if (TShirts)
        {
            PlayerTShirt1.GetComponent<Renderer>().material.color = hexToColor(color);
            PlayerTShirt2.GetComponent<Renderer>().material.color = hexToColor(color);
            PlayerTShirt3.GetComponent<Renderer>().material.color = hexToColor(color);
        }
        if (Pants)
        {
            PlayerPants1.GetComponent<Renderer>().material.color = hexToColor(color);
            PlayerPants2.GetComponent<Renderer>().material.color = hexToColor(color);
        }
        if(Shoes)
        {
            PlayerShoes1.GetComponent<Renderer>().material.color = hexToColor(color);
            PlayerShoes2.GetComponent<Renderer>().material.color = hexToColor(color);
        }
    }

    public static Color hexToColor(string hex)
    {
        return new Color32(byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber), 
                            byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber),
                            byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber),
                            255);
    }
}

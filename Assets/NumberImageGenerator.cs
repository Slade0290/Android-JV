using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberImageGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject Image0;
        
    [SerializeField]
    private GameObject Image1;
        
    [SerializeField]
    private GameObject Image2;
        
    [SerializeField]
    private GameObject Image3;
        
    [SerializeField]
    private GameObject Image4;
        
    [SerializeField]
    private GameObject Image5;
        
    [SerializeField]
    private GameObject Image6;
        
    [SerializeField]
    private GameObject Image7;
        
    [SerializeField]
    private GameObject Image8;

    [SerializeField]
    private GameObject Image9;

    private int posX, posZ;

    void Start()
    {
        GenerateIntInImage(CharacterColorPref.score);
    }

    public void GenerateIntInImage(int value)
    {
        string val = value.ToString();

    }

    public GameObject whichNumber(string number)
    {
        switch(number)
        {
            case "0":
                Image0.SetActive(true);
                return Image0;
            case "1":
                Image1.SetActive(true);
                return Image1;
            case "2":
                Image2.SetActive(true);
                return Image2;
            case "3":
                Image3.SetActive(true);
                return Image3;
            case "4":
                Image4.SetActive(true);
                return Image4;
            case "5":
                Image5.SetActive(true);
                return Image5;
            case "6":
                Image6.SetActive(true);
                return Image6;
            case "7":
                Image7.SetActive(true);
                return Image7;
            case "8":
                Image8.SetActive(true);
                return Image8;
            case "9":
                Image9.SetActive(true);
                return Image9;
            default:
                return null;
        }
    }
}

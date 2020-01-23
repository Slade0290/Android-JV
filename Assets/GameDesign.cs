using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameDesign : MonoBehaviour
{
    [SerializeField]
    private GameObject timer;

    private float timeLeft = 60.0f;

    public TextMeshProUGUI text;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        text.text = "Time Left:" + Mathf.Round(timeLeft);
        if (timeLeft < 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}

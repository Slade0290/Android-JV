using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI score;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        score.text = CharacterColorPref.score.ToString();
    }
}

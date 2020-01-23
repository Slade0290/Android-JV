using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnScript : MonoBehaviour
{
    [SerializeField]
    private GameObject PlayerPrefab;

    // Start is called before the first frame update
    void Start()
    {
        GameObject Player = Instantiate(PlayerPrefab);
        Player.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

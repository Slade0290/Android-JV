using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PnJGeneratorScript : MonoBehaviour
{

    private GameObject[] SpawnBeaconList;
    private GameObject[] GSpawnBeaconList;

    [SerializeField]
    private GameObject PnJ;

    [SerializeField]
    private GameObject GPnJ;

    // Start is called before the first frame update
    void Start()
    {
        SpawnBeaconList = GameObject.FindGameObjectsWithTag("spawn");
        for (int i = 0; i < SpawnBeaconList.Length; i++)
        {
            GameObject tmp = Instantiate(PnJ);
            tmp.transform.position = SpawnBeaconList[i].transform.position;
        }
        GSpawnBeaconList = GameObject.FindGameObjectsWithTag("Gspawn");
        for (int i = 0; i < GSpawnBeaconList.Length; i++)
        {
            GameObject tmp = Instantiate(GPnJ);
            tmp.transform.position = GSpawnBeaconList[i].transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

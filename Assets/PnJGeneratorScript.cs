using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Text;
using System;


public class PnJGeneratorScript : MonoBehaviour
{

    private GameObject[] SpawnBeaconList;
    private GameObject[] GSpawnBeaconList;

    [SerializeField]
    private GameObject PnJ;

    [SerializeField]
    private GameObject GPnJ;

    private List<GameObject> PnJList;

    // Start is called before the first frame update
    void Start()
    {
        PnJList = new List<GameObject>();
        SpawnBeaconList = GameObject.FindGameObjectsWithTag("spawn");
        for (int i = 0; i < SpawnBeaconList.Length; i++)
        {
            GameObject tmp = Instantiate(PnJ);
            tmp.transform.position = SpawnBeaconList[i].transform.position;
            if(i+1 < SpawnBeaconList.Length) 
                tmp.GetComponent<NavMeshAgent>().SetDestination(SpawnBeaconList[i+1].transform.position);
            else 
                tmp.GetComponent<NavMeshAgent>().SetDestination(SpawnBeaconList[0].transform.position);
            PnJList.Add(tmp);
        }
        GSpawnBeaconList = GameObject.FindGameObjectsWithTag("GSpawn");
        for (int i = 0; i < GSpawnBeaconList.Length; i++)
        {
            GameObject tmp = Instantiate(GPnJ);
            tmp.transform.position = GSpawnBeaconList[i].transform.position;
            if (i + 1 < GSpawnBeaconList.Length)
                tmp.GetComponent<NavMeshAgent>().SetDestination(GSpawnBeaconList[i + 1].transform.position);
            else
                tmp.GetComponent<NavMeshAgent>().SetDestination(GSpawnBeaconList[0].transform.position);
            PnJList.Add(tmp);
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var item in PnJList)
        {
            if(item.GetComponent<NavMeshAgent>().remainingDistance < 3)
            {
                System.Random rand = new System.Random();
                GetComponent<NavMeshAgent>().SetDestination(SpawnBeaconList[rand.Next(0, SpawnBeaconList.Length)].transform.position);
            }
        }
    }
}

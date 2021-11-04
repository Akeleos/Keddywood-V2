using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    public GameObject prefab1;
    public GameObject prefab2;
    private Vector3 spawnPos1 = new Vector3(-10, 0, -26);
    private Vector3 spawnPos2 = new Vector3(-15, 0, -2);
    private float startDelay = 2;
    private float repeatRate = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObs", startDelay, repeatRate);
    }
    void SpawnObs()
    {
        Instantiate(prefab1, spawnPos1, prefab1.transform.rotation);
        Instantiate(prefab2, spawnPos2, prefab2.transform.rotation);
    }

  
}

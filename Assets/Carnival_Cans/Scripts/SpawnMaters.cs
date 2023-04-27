using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMaters : MonoBehaviour
{
    public GameObject Mater;
    public GameObject materSpawner;
    public Vector3 materSpawnLoc;

    private void Start()
    {
        materSpawnLoc = materSpawner.transform.position; 
    }

    public void SpawnMaterFunction()
    {
        Debug.Log("Spawned a Tomato!");
        Instantiate(Mater, materSpawnLoc, Quaternion.identity);
    }
}

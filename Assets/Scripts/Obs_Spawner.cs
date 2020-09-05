using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;
public class Obs_Spawner : MonoBehaviour
{
    public GameObject[] obs_prefabs;
    private Transform playerTransform;
    private float spawnZ = 0.0f;
    private float tileLength = 12.0f;
    private int Amount_Title_OnScreen = 11;
    private float safeZone = 15.0f;
    private List<GameObject> AcitveTiles;
    private int Last_Prefab_index = 0;
    private void Start()
    {
        AcitveTiles = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        
        for(int i =0; i< Amount_Title_OnScreen; i++)
        {
            if (i < 2)
            SpawnTile(0);
            else
            SpawnTile();
        }

    }

    private void Update()
    {
        if(playerTransform.position.z-safeZone> (spawnZ - Amount_Title_OnScreen * tileLength))
        {
            SpawnTile();
            DelectTile();
          
            //Spawn_cubes.Instance_Shatter.Delete_Shatter();
        }
    }
    private void SpawnTile(int Prefab_Index = -1)
    {

        GameObject go,g;
        if (Prefab_Index == -1)
            go = Instantiate(obs_prefabs[Random_number()]) as GameObject;
           
        else
            go = Instantiate(obs_prefabs[Prefab_Index]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward*spawnZ;
        spawnZ += tileLength;
        AcitveTiles.Add(go);
    }
    private void DelectTile()
    {
        Destroy(AcitveTiles[0]);
        AcitveTiles.RemoveAt(0);
    }

    private int Random_number()
    {
        if(obs_prefabs.Length <= 1)
        return 0;

        int randomIndex = Last_Prefab_index;
        while(randomIndex == Last_Prefab_index)
        {
            randomIndex = Random.Range(0, obs_prefabs.Length);
        }
        Last_Prefab_index = randomIndex;
        return randomIndex;
    }
}

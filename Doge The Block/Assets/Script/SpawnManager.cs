using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject blocks;
    private float spawnPoseZ = 4.1f;
    private float spawnPoseY = 0f;
    private int startDelay = 2;
    private float spawnInterval = 1.5f;
    int [] spawnloc = new int[4]  { -3, -1, 1, 3};
    


    private void Start()
    {
        InvokeRepeating("SpawnRandomBlocks", startDelay, spawnInterval);

    }

    void SpawnRandomBlocks()
    {
        int ran = Random.Range(0, spawnloc.Length);
        Vector3[] spawnPos = new Vector3[4];
        for (int i=0; i<spawnloc.Length; i++)
        {
            spawnPos[i] = new Vector3(spawnloc[i], spawnPoseY,spawnPoseZ);
        }

        for (int i = 0; i < spawnloc.Length; i++){
            if (ran != i)
            {
                Instantiate(blocks, spawnPos[i], blocks.transform.rotation);
            }
            
        }
        

    }
}

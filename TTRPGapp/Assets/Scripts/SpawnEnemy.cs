using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnEnemy : MonoBehaviour
{
    public int ndn = 1;

    //public Dropdown enemyNdn;
    public GameObject enemyPrefab;
    public GameObject enemySpawnLocation;


    public void handleInputData(int val)
    {
        ndn = val + 1;

    }
    public void spawnEnemy()
    {
        Instantiate(enemyPrefab, enemySpawnLocation.transform);
    }

}

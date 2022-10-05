using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStatGen : MonoBehaviour
{

    public int ndn;
    public int numOfTags;
    public int sheildMax;
    public int sheildCurrent;
    public int damageMin;
    public int damageMid;
    public int damageMax;

    public GameObject enemyTag;
    public GameObject enemyTagSpawn;
    //public GameObject enemyNdn;
    public SpawnEnemy enemySpawner;


    void Awake()
    {
        enemySpawner = GameObject.FindObjectOfType<SpawnEnemy>();
        ndn = enemySpawner.ndn;
        numOfTags = 0;

        while ( numOfTags < ndn)
        {
            Instantiate(enemyTag, enemyTagSpawn.transform);
            numOfTags++;
        }
    }
}

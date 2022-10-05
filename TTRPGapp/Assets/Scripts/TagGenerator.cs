using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TagGenerator : MonoBehaviour
{
    public TMP_Text tagName;
    public EnemyTagsSO enemytag;

    int index;

    void Awake()
    {
        EnemyTagsSO[] tag = Resources.LoadAll<EnemyTagsSO>("Enemy/tags");

        index = Random.Range(0, tag.Length);
        enemytag = tag[index];
        tagName.text = enemytag.tagName;
        tag.SetValue(false, index);
    }


}
//spawnPoints = GameObject.FindGameObjectsWithTag("point");
//index = Random.Range(0, spawnPoints.Length);
//currentPoint = spawnPoints[index];
//print(currentPoint.name);
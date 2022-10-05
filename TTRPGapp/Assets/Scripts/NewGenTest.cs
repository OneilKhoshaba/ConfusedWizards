using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGenTest : MonoBehaviour
{
    //public EnemyTagsSO[] tagGen;
    public List<EnemyTagsSO> tagGen;
    public EnemyTagsSO[] tagArray;
    int index;
    // Start is called before the first frame update
    void Awake()
    {
        tagArray = Resources.LoadAll<EnemyTagsSO>("Enemy/tags");
    }

    public void GenTags()
    {
        tagGen = new List<EnemyTagsSO>(tagArray);

        index = Random.Range(0, tagGen.Count);
        //PrintValues(tagGen);
        Debug.Log(tagGen[index]);
        tagGen.RemoveAt(index);
        //PrintValues(tagGen);
    }

    public static void PrintValues(IEnumerable myList)
    {
        foreach (EnemyTagsSO obj in myList)
            Debug.Log("   {0}" + obj);
        //Debug.Log();
    }
}

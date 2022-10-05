using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerviousRollTracker : MonoBehaviour
{
    public PlayerUD playerUD;
    public GameObject spawnLocation;
    [Space(10)]
    public GameObject success;
    public GameObject advantage;
    public GameObject neutural;
    public GameObject disadvantage;
    public GameObject fail;
    public List<GameObject> perviousRollList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void removeFullPerviousList()
    {
        if (perviousRollList.Count == 5)
        {

            GameObject firstRoll = perviousRollList[0];
            GameObject.Destroy(firstRoll);
            perviousRollList.RemoveAt(0);
        }
        else
        {
            return;
        }
    }

    public void spawnPerviousRoll()
    {
        removeFullPerviousList();

        if (playerUD.firstRoll == false)
        {
            if (playerUD.totalDiceResult > 4)
            {
                GameObject newPastRoll = Instantiate(success, spawnLocation.transform);
                perviousRollList.Add(newPastRoll);
            }

            if (playerUD.totalDiceResult > 0 && playerUD.totalDiceResult < 5)
            {
                GameObject newPastRoll = Instantiate(advantage, spawnLocation.transform);
                perviousRollList.Add(newPastRoll);
            }

            if (playerUD.totalDiceResult == 0)
            {
                GameObject newPastRoll = Instantiate(neutural, spawnLocation.transform);
                perviousRollList.Add(newPastRoll);
            }

            if (playerUD.totalDiceResult < 0 && playerUD.totalDiceResult > -5)
            {
                GameObject newPastRoll = Instantiate(disadvantage, spawnLocation.transform);
                perviousRollList.Add(newPastRoll);
            }

            if (playerUD.totalDiceResult < -4)
            {
                GameObject newPastRoll = Instantiate(fail, spawnLocation.transform);
                perviousRollList.Add(newPastRoll);
            }
        }

    }
}

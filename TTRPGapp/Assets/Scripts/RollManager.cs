using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RollManager : MonoBehaviour
{

    public PlayerUD PlayerUD;

    [Space(10)]
    public GameObject posDice;
    public GameObject PosDiceSpawn;
    [Space(10)]
    public GameObject neutDice;
    public GameObject neutDiceSpawn;
    [Space(10)]
    public GameObject negDice;
    public GameObject negDiceSpawn;
    [Space(10)]
    public PlayerUD playerUD;
    public GameObject success;
    public GameObject advantage;
    public GameObject neutural;
    public GameObject disadvantage;
    public GameObject fail;
    public TMP_Text successText;
    public TMP_Text failsText;
    public TMP_Text falloutText;
    [Space(10)]
    public List<GameObject> posDiceList = new List<GameObject>();
    public List<GameObject> negDiceList = new List<GameObject>();
    public GameEvent rollEvent;
    public GameEvent perviousListEvent;
    public TMP_Text negDiceCounter;
    public GameObject setRollValues;
    public GameObject diceRoller;
    public PlayerAbility usedAbility;
    public GameEvent claerDice;

    private void Awake()
    {
        resetDiceRes();

        //for (int i = 0; i < PlayerUD.posDiceAmount; i++)
        //{
        //    addPosDice();
        //}

        for (int j = 0; j < 5; j++)
        {
            Instantiate(neutDice, neutDiceSpawn.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        usedAbility = playerUD.usedAbility;
        setDiceRes();
        setTrackerRes();
        //negDiceCounter.text = "" + negDiceList.Count;
    }

    public void addPosDice()
    {
        GameObject newPosDice = Instantiate(posDice, PosDiceSpawn.transform);
        posDiceList.Add(newPosDice);
    }

    public void removePosDice()
    {
        int lastOfList = posDiceList.Count - 1;
        GameObject.Destroy(posDiceList[lastOfList]);
        posDiceList.RemoveAt(lastOfList);
    }

    public void addNegDice()
    {
        GameObject newNegDice = Instantiate(negDice, negDiceSpawn.transform);
        negDiceList.Add(newNegDice);
        
    }

    public void removeNegDice()
    {
        int lastOfList = negDiceList.Count - 1;
        GameObject.Destroy(negDiceList[lastOfList]);
        negDiceList.RemoveAt(lastOfList);
    }

    public void addCapDice()
    {
        playerUD.negDiceAmount += playerUD.capCounter;
    }

    public void addCap()
    {
        if (usedAbility.costCap == true)
        {
            playerUD.capCounter += usedAbility.costAmount;
        }
    }

    public void addAbilityVariables()
    {

        playerUD.posDiceAmount += usedAbility.effectAmount;
        //if (usedAbility.addPosDice == true)
        //{
        //    playerUD.posDiceAmount += usedAbility.effectAmount;
        //}
        //if (usedAbility.addSuccess == true)
        //{
        //    playerUD.posDiceResult += usedAbility.effectAmount;
        //}
        //if (usedAbility.removeNegDice == true)
        //{
        //    playerUD.negDiceAmount -= usedAbility.effectAmount;
        //}
    }

    public void spwanDiceFromPool()
    {
        for (int l = 0; l < (playerUD.posDiceAmount + playerUD.bonusPosDice); l++)
        {
            addPosDice();
        }
        for (int p = 0; p < playerUD.negDiceAmount; p++)
        {
            addNegDice();
        }
    }

    public void clearDicePool()
    {
        claerDice.Invoke();
    }
    public void endTurn()
    {
        playerUD.capCounter = 0;
    }

    public void setDiceRes()
    {
        successText.text = "Success = " + playerUD.posDiceResult;
        failsText.text = "fails = " + playerUD.negDiceResult;
        falloutText.text = "fallouts =" + playerUD.falloutResult;
    }

    public void resetDiceRes()
    {
        playerUD.posDiceResult = 0;
        playerUD.falloutResult = 0;
        playerUD.negDiceResult = 0;
        playerUD.totalDiceResult = 0;
    }

    public void rollDice()
    {        

        perviousListEvent?.Invoke();
        resetDiceRes();
        addAbilityVariables();
        addCapDice();
        spwanDiceFromPool();
        //setRollValues.SetActive(false);
        diceRoller.SetActive(true);
        rollEvent?.Invoke();
        addCap();
        playerUD.firstRoll = false;
    }

    public void setTrackerRes()
    {
        if (playerUD.totalDiceResult > 4)
        {
            success.SetActive(true);
            advantage.SetActive(false);
            neutural.SetActive(false);
            disadvantage.SetActive(false);
            fail.SetActive(false);
        }

        if (playerUD.totalDiceResult > 0 && playerUD.totalDiceResult < 5)
        {
            success.SetActive(false);
            advantage.SetActive(true);
            neutural.SetActive(false);
            disadvantage.SetActive(false);
            fail.SetActive(false);
        }

        if (playerUD.totalDiceResult == 0)
        {
            success.SetActive(false);
            advantage.SetActive(false);
            neutural.SetActive(true);
            disadvantage.SetActive(false);
            fail.SetActive(false);
        }

        if (playerUD.totalDiceResult < 0 && playerUD.totalDiceResult > -5)
        {
            success.SetActive(false);
            advantage.SetActive(false);
            neutural.SetActive(false);
            disadvantage.SetActive(true);
            fail.SetActive(false);
        }

        if (playerUD.totalDiceResult < -4)
        {
            success.SetActive(false);
            advantage.SetActive(false);
            neutural.SetActive(false);
            disadvantage.SetActive(false);
            fail.SetActive(true);
        }
    }
}

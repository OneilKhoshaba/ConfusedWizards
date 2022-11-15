using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiceRoller : MonoBehaviour
{

    public TMP_Text resText; //element that shows result in GUI
    public PlayerUD pD;

    


    public enum DiceType { pos, neut, neg };
    public DiceType dType;

    public void rollPosDiceV2()
    {

        int diceRis = Random.Range(1, 7);
        Debug.Log(diceRis);
        if (diceRis == 1 || diceRis == 2 || diceRis == 3)
        {
            pD.posDiceResult++;
            pD.totalDiceResult++;
            resText.text = "+1";
        }
        if (diceRis == 6 || diceRis == 5 || diceRis == 4)
        {
            pD.posDiceResult += 2;
            pD.totalDiceResult += 2;
            resText.text = "+2";
        }

    }

    public void rollNeutDice()
    {
        int diceRis = Random.Range(1, 7);
        Debug.Log(diceRis);
        //resText.text = diceRis.ToString();
        if (diceRis == 1 || diceRis == 2)
        {
            pD.negDiceResult++;
            pD.totalDiceResult--;
            resText.text = "-1";
        }
        if (diceRis == 3 || diceRis == 4)
        {
            pD.falloutResult++;
            resText.text = "F";
        }
        if (diceRis == 5 || diceRis == 6)
        {
            pD.posDiceResult++;
            pD.totalDiceResult--;
            resText.text = "+1";
        }

    }

    public void rollNegDiceV2()
    {
        int diceRis = Random.Range(1, 7);
        Debug.Log(diceRis);

        if (diceRis == 3 || diceRis == 1 || diceRis == 2)
        {
            pD.negDiceResult++;
            pD.totalDiceResult--;
            resText.text = "-1";
        }
        if (diceRis == 6 || diceRis == 4 || diceRis == 5)
        {
            pD.negDiceResult += 2;
            pD.totalDiceResult -=2;
            resText.text = "-2";
        }

    }

    public void clearDice()
    {
        Destroy(gameObject);
    }
}

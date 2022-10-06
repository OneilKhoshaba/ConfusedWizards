using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiceTextCounter : MonoBehaviour
{
    public TMP_Text counterText;
    public bool negCount;
    public PlayerUD PlayerUD;
    public int bonusPosDiceCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(negCount == true)
        {
            counterText.text = "" + (PlayerUD.negDiceAmount + PlayerUD.capCounter);
        }
        else
        {
            bonusPosDiceCounter++;
            counterText.text = "" + bonusPosDiceCounter;
        }
    }
}

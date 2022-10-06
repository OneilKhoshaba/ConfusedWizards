using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetRollValues : MonoBehaviour
{
    public CharacterData characterData;

    public PlayerUD PlayerUD;

    public PlayerAbility ability;
    
    public TMP_Dropdown atSelect;

    public int ndn;


    public void Awake()
    {
        ability = PlayerUD.usedAbility;
    }

    public void Update()
    {
        SetChoosenAtribute();
    }
    public void addToPosPool()
    {
        PlayerUD.bonusPosDice++;
    }

    public void subFromPosPool()
    {
        PlayerUD.bonusPosDice--;
    }

    public void addToNegPool()
    {
        PlayerUD.negDiceAmount++;
    }
    public void subFromNegPool()
    {
        if (PlayerUD.negDiceAmount > 0)
        {
            PlayerUD.negDiceAmount--;
        }
        else
        {
            return;
        }
    }

    public void setAtButton()
    {

    }

    public void addToCapCounter()
    {
        PlayerUD.capCounter += ability.costAmount;
    }

    public void abilityEffect()
    {
        if (ability.addPosDice == true)
        {

        }
    }
    public void SetChoosenAtribute()
    {
        
        if (atSelect.value == 0) //set to Brawl
        {
            PlayerUD.posDiceAmount = characterData.Brawl;
        }
        if (atSelect.value == 1) //set to Ranged
        {
            PlayerUD.posDiceAmount = characterData.Ranged;
        }
        if (atSelect.value == 2) //set to Brawn
        {
            PlayerUD.posDiceAmount = characterData.Brawn;
        }
        if (atSelect.value == 3) //set to Finesse
        {
            PlayerUD.posDiceAmount = characterData.Finesse;
        }
        if (atSelect.value == 4) //set to Ingenunity
        {
            PlayerUD.posDiceAmount = characterData.Ingenunity;
        }
        if (atSelect.value == 5) //set to Mental
        {
            PlayerUD.posDiceAmount = characterData.Mental;
        }
        if (atSelect.value == 6) //set to Social
        {
            PlayerUD.posDiceAmount = characterData.Social;
        }
        if (atSelect.value == 7) //set to Awarness
        {
            PlayerUD.posDiceAmount = characterData.Awarness;
        }

    }

    public void setUsedAbility()
    {
        PlayerUD.usedAbility = ability;
    }
}

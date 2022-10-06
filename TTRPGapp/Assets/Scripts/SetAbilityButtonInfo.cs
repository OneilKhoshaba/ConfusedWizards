using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetAbilityButtonInfo : MonoBehaviour
{

    public TMP_Text text;
    public PlayerAbility ability;
    public PlayerAbility attack;
    public PlayerAbility exert;
    public CharacterData characterData;
    public PlayerUD playerUD;
    public int abilityNumber;
    public bool combatSkill;
    public bool generalSkill;
    public GameObject diceRollPanle;

    // Start is called before the first frame update
    void Start()
    {
        characterData = playerUD.characterData;
        if(generalSkill == false)
        {
        if(combatSkill == true)
        {
            ability = characterData.combatAbilities[abilityNumber];
        }
        if(combatSkill == false)
        {
            ability = characterData.socialAbilities[abilityNumber];
        }
        text.text = ability.abilityName;
        }
        else
        {
            return;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setUsedAbility()
    {
        playerUD.usedAbility = ability;
        playerUD.posDiceAmount = 0;
        playerUD.bonusPosDice = 0;
        playerUD.negDiceAmount = 0;
        diceRollPanle.SetActive(true);
    }
    public void setAttackAbility()
    {
        playerUD.usedAbility = attack;
        playerUD.posDiceAmount = 0;
        playerUD.bonusPosDice = 0;
        playerUD.negDiceAmount = 0;
        diceRollPanle.SetActive(true);
    }
    public void setExertAbility()
    {
        playerUD.usedAbility = exert;
        playerUD.posDiceAmount = 0;
        playerUD.bonusPosDice = 0;
        playerUD.negDiceAmount = 0;
        diceRollPanle.SetActive(true);
    }
}

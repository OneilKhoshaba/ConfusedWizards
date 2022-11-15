using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class abilityInfoButton : MonoBehaviour
{
    //public TMP_Text text;
    public PlayerAbility ability;
    public CharacterData characterData;
    public PlayerUD playerUD;
    public GameObject AbilityInfoPanle;
    public int abilityNumber;
    public bool combatSkill;
    public bool generalSkill;

    // Start is called before the first frame update
    void Start()
    {
        characterData = playerUD.characterData;
        if (generalSkill == false)
        {
            if (combatSkill == true)
            {
                ability = characterData.combatAbilities[abilityNumber];
            }
            if (combatSkill == false)
            {
                ability = characterData.socialAbilities[abilityNumber];
            }
            //text.text = ability.abilityName;
        }
        else
        {
            return;
        }

    }

    public void setUsedAbility()
    {
        playerUD.usedAbility = ability;
        AbilityInfoPanle.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

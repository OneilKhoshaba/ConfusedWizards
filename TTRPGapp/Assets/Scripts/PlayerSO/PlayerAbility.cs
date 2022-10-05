using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerAbility", menuName = "Player Ability", order = 7)]
public class PlayerAbility : ScriptableObject
{
    public string abilityName;

    [TextArea (1,100)]
    public string abilityDes;
    [Space(10)]
    public bool costCap;
    public bool costEffort;
    public int costAmount;

    public bool addPosDice;
    public bool addSuccess;
    public bool removeNegDice;
    public bool passive;//passive adds nothing to a roll but dose somthing else
    public int effectAmount;

    //public enum Cost { effort, cap}
    //public Cost costOfAbility;
    

    //public enum Effect { addPosDice, addSuccess, removeNegDice, passive} //passive adds nothing to a roll but dose somthing else
    //public Effect effect;
    


}

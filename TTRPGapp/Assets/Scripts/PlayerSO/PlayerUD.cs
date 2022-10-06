using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerUD", menuName = "Player User Data", order = 5)]
public class PlayerUD : ScriptableObject
{
    public int posDiceAmount;
    public int neutDiceAmount = 5;
    public int negDiceAmount;
    [Space (10)]
    public int posDiceResult;
    public int neutDiceResult;
    public int negDiceResult;
    public int totalDiceResult;
    [Space(10)]
    public int falloutResult;
    public bool firstRoll = true;
    public int capCounter;
    public PlayerAbility usedAbility;
    public CharacterData characterData;

}

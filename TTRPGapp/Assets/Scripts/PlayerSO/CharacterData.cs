using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "Character Data", order = 6)]

public class CharacterData : ScriptableObject
{
    public int Brawl;
    public int Ranged;
    public int Brawn;
    public int Finesse;
    public int Ingenunity;
    public int Mental;
    public int Social;
    public int Awarness;

    public bool plotArmour;
    public int effort;
    public int effortCurrent;
    public int sheildMax;
    public int sheildCurrent;

    public List<PlayerAbility> combatAbilities;
    public List<PlayerAbility> socialAbilities;

    [TextArea(1, 100)]
    public string characterDes;
    public Sprite characterImage;
}

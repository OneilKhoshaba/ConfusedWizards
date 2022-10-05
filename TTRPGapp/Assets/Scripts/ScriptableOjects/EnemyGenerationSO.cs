using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Enermy Generation Data", order = 1)]
public class SpawnManagerScriptableObject : ScriptableObject
{
    public int enemyHealth;

    public int numberOfDice;
    public int maxDice;

    //public string[] tag = new string { "Pack", "Fly", "Aquatic", "Amphibious", "Burrowing", "Poison", "Fire", "Bestial", "Ice", "Sonic", "Acid", "Berserker", "Machinery"};
}

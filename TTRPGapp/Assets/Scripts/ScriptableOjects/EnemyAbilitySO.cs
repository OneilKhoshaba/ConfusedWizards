using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ability", menuName = "Ability Data", order = 3)]
public class EnemyAbilitySO : ScriptableObject
{
    public string abilityName;

    [TextArea(1, 100)]
    public string abilityDes;
}

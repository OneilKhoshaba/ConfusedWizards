using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapondata", menuName = "Weapon Data", order = 10)]

public class WeaponSO : ScriptableObject
{
    public int minDamage;
    public int midDamage;
    public int maxDamage;
    public string weaponClass;
    public string weaponrange;
}

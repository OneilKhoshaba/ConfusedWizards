using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetWeaponStats : MonoBehaviour
{
    public PlayerUD PlayerUD;
    public CharacterData characterData;
    public WeaponSO weapon;
    public TMP_Text weaponName;
    public TMP_Text damage;
    public TMP_Text weaponClass;
    public TMP_Text range;

    void Awake()
    {
        characterData = PlayerUD.characterData;
        weapon = characterData.weapon;
        weaponName.text = weapon.name;
        setWeapon();
    }

    void setWeapon()
    {
        damage.text = "" + weapon.midDamage + " / " + weapon.midDamage + " / " + weapon.maxDamage;
        weaponClass.text = "" + weapon.weaponClass;
        range.text = "" + weapon.weaponrange;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

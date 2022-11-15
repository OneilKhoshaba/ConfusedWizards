using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AbilityInfoManager : MonoBehaviour
{
    public TMP_Text abilityName;
    public TMP_Text abilityDes;
    public PlayerUD PlayerUD;

    // Start is called before the first frame update
    void Awake()
    {
        abilityName.text = "" + PlayerUD.usedAbility.abilityName;
        abilityDes.text = "" + PlayerUD.usedAbility.abilityDes;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetCharacterButton : MonoBehaviour
{
    public GameObject characterInfoPanel;
    public GameObject characterInfoPanellocation;
    public CharacterData characterData;
    public TMP_Text charachterName;
    public PlayerUD PlayerUD;

    void Awake()
    {
        charachterName.text = characterData.name;
    }


    public void spawnCharacterInfo()
    {
        PlayerUD.selectedCharacter = characterData;
        characterInfoPanel.SetActive(true);
    }
}

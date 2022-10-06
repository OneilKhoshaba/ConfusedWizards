using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterInfoManager : MonoBehaviour
{
    public PlayerUD PlayerUD;
    public GameObject characterPanel;
    public GameObject characterSelect;
    public GameObject characterInfo;
    public CharacterData CharacterData;
    public TMP_Text charName;
    public Image characterArt;
    public TMP_Text charDes;
    public TMP_Text brawl;
    public TMP_Text ranged;
    public TMP_Text brwan;
    public TMP_Text finesse;
    public TMP_Text ingenuity;
    public TMP_Text mental;
    public TMP_Text social;
    public TMP_Text awarness;

    // Start is called before the first frame update
    void Awake()
    {


    }
    // Update is called once per frame
    void Update()
    {
        CharacterData = PlayerUD.selectedCharacter;
        charName.text = "" + CharacterData.name;
        characterArt.sprite = CharacterData.characterImage;
        charDes.text = CharacterData.characterDes;
        setAtOnStatSheet();
    }

    public void setAtOnStatSheet()
    {
        brawl.text = "" + CharacterData.Brawl;
        ranged.text = "" + CharacterData.Ranged;
        brwan.text = "" + CharacterData.Brawn;
        finesse.text = "" + CharacterData.Finesse;
        ingenuity.text = "" + CharacterData.Ingenunity;
        mental.text = "" + CharacterData.Mental;
        social.text = "" + CharacterData.Social;
        awarness.text = "" + CharacterData.Awarness;
    }

    public void selectCharacter()
    {
        PlayerUD.characterData = PlayerUD.selectedCharacter;
        characterSelect.SetActive(false);
        characterInfo.SetActive(false);
        characterPanel.SetActive(true);

    }

    public void chooseOther()
    {
        this.gameObject.SetActive(false);
    }


}

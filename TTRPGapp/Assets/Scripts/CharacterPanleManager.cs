using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterPanleManager : MonoBehaviour
{
    public CharacterData characterData;
    public PlayerUD PlayerUD;
    public TMP_Text charName;
    public GameObject effort1;
    public GameObject effort2;
    public GameObject effort3;
    public GameObject effort4;
    public GameObject effort5;
    public GameObject plotArmour;
    public TMP_Text brawl;
    public TMP_Text ranged;
    public TMP_Text brawn;
    public TMP_Text finesse;
    public TMP_Text ingenuity;
    public TMP_Text mental;
    public TMP_Text social;
    public TMP_Text awarness;


    // Start is called before the first frame update
    void Start()
    {
        characterData = PlayerUD.characterData;
        charName.text = "" + characterData.name;
    }

    // Update is called once per frame
    void Update()
    {

        if (characterData.plotArmour == false)
        {
            plotArmour.SetActive(false);
        }
        if (characterData.plotArmour == true)
        {
            plotArmour.SetActive(true);
        }
        seteffort();
        setAtOnStatSheet();


    }

    public void setAtOnStatSheet()
    {
        brawl.text = "" + characterData.Brawl;
        ranged.text = "" + characterData.Ranged;
        brawn.text = "" + characterData.Brawn;
        finesse.text = "" + characterData.Finesse;
        ingenuity.text = "" + characterData.Ingenunity;
        mental.text = "" + characterData.Mental;
        social.text = "" + characterData.Social;
        awarness.text = "" + characterData.Awarness;
    }

    public void seteffort()
    {
        if (characterData.effort == 0)
        {
            effort1.SetActive(false);
            effort2.SetActive(false);
            effort3.SetActive(false);
            effort4.SetActive(false);
            effort5.SetActive(false);
        }
        if (characterData.effort == 1)
        {
            effort1.SetActive(true);
            effort2.SetActive(false);
            effort3.SetActive(false);
            effort4.SetActive(false);
            effort5.SetActive(false);
        }
        if (characterData.effort == 2)
        {
            effort1.SetActive(true);
            effort2.SetActive(true);
            effort3.SetActive(false);
            effort4.SetActive(false);
            effort5.SetActive(false);
        }
        if (characterData.effort == 3)
        {
            effort1.SetActive(true);
            effort2.SetActive(true);
            effort3.SetActive(true);
            effort4.SetActive(false);
            effort5.SetActive(false);
        }
        if (characterData.effort == 4)
        {
            effort1.SetActive(true);
            effort2.SetActive(true);
            effort3.SetActive(true);
            effort4.SetActive(true);
            effort5.SetActive(false);
        }
        if (characterData.effort == 5)
        {
            effort1.SetActive(true);
            effort2.SetActive(true);
            effort3.SetActive(true);
            effort4.SetActive(true);
            effort5.SetActive(true);
        }
    }
}

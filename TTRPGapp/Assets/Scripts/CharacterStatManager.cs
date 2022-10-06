using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterStatManager : MonoBehaviour
{
    public PlayerUD PlayerUD;
    public CharacterData characterData;
    public TMP_Text shieldText;
    public TMP_Text capCounter;
    public GameObject effort1;
    public GameObject effort2;
    public GameObject effort3;
    public GameObject effort4;
    public GameObject effort5;
    public GameObject plotArmour;
    public GameObject healthy;
    public GameObject Hurt;
    public GameObject wounded;
    public GameObject injured;
    public GameObject downed;
    public TMP_Dropdown healthTrackerSelect;


    // Start is called before the first frame update
    void Start()
    {
        characterData = PlayerUD.characterData;
        //charName.text = "" + characterData.name;
    }

    // Update is called once per frame
    void Update()
    {
        shieldText.text = "Shields " + characterData.sheildCurrent +"/" + characterData.sheildCurrent;

        if (characterData.plotArmour == false)
        {
            plotArmour.SetActive(false);
        }
        if (characterData.plotArmour == true)
        {
            plotArmour.SetActive(true);
        }
        seteffort();
        setHealthTracker();
        capCounter.text = "CAP: " + PlayerUD.capCounter;
    }
    public void endCombat()
    {
        PlayerUD.capCounter = 0;
        characterData.effortCurrent = characterData.effort;
    }

    public void setHealthTracker()
    {
        if (PlayerUD.playerHealth == 1)
        {
            healthy.SetActive(true);
            Hurt.SetActive(true);
            wounded.SetActive(true);
            injured.SetActive(true);
            downed.SetActive(false);
        }
        if (PlayerUD.playerHealth == 2)
        {
            healthy.SetActive(true);
            Hurt.SetActive(true);
            wounded.SetActive(true);
            injured.SetActive(false);
            downed.SetActive(true);
        }
        if (PlayerUD.playerHealth == 3)
        {
            healthy.SetActive(true);
            Hurt.SetActive(true);
            wounded.SetActive(false);
            injured.SetActive(true);
            downed.SetActive(true);
        }
        if (PlayerUD.playerHealth == 4)
        {
            healthy.SetActive(true);
            Hurt.SetActive(false);
            wounded.SetActive(true);
            injured.SetActive(true);
            downed.SetActive(true);
        }
        if (PlayerUD.playerHealth == 5)
        {
            healthy.SetActive(false);
            Hurt.SetActive(true);
            wounded.SetActive(true);
            injured.SetActive(true);
            downed.SetActive(true);
        }
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

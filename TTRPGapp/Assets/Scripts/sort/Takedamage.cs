using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Takedamage : MonoBehaviour
{
    public CharacterData characterData;
    public PlayerUD playerUD;
    public int damageAmount;
    public TMP_Text damageAmountText;


    // Start is called before the first frame update
    void Awake()
    {
        characterData = playerUD.characterData;
        damageAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void add1()
    {
        damageAmount++;
    }

    public void add5()
    {
        damageAmount+=5;
    }
    public void sub1()
    {
        damageAmount--;
    }
    public void sub5()
    {
        damageAmount-=5;
    }

    public void takeDamage()
    {
        characterData.sheildCurrent -= damageAmount;
        this.gameObject.SetActive(false);
    }
}

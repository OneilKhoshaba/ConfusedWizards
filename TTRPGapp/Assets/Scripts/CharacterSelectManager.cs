using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectManager : MonoBehaviour
{
    public List<CharacterData> characterList = new List<CharacterData>();
    public CharacterData characterData;
    public GameObject characterSelector;
    public GameObject characterPanle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnCharacters()
    {
    //    foreach(CharacterData character in characterList)
    //    {
    //        characterData = character;
    //        GameObject newChar = Instantiate(characterSelector, characterPanle.transform);
    //        newChar.GetComponents<SetCharacterButton>();
    //        //newChar.CharacterData = character;
    //    }
    }
}

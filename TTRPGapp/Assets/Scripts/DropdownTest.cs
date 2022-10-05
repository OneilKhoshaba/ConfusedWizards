using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DropdownTest : MonoBehaviour
{
    public bool isPack;

    public string resourcePath;

    public Dropdown dropdown;
    // Start is called before the first frame update
    void Start()
    {
        if (isPack)
        {
            resourcePath = "Pack";
        }
        else
        {
            resourcePath = "Fly";
        }
        //var dropdown = transform.GetComponent<Dropdown>();

        dropdown.options.Clear();

        //List<Object> ablities = Resources.LoadAll("Enemy/Abilities/Pack");
        Object[] abilities = Resources.LoadAll("Enemy/Abilities/" + resourcePath);

        foreach (var ability in abilities)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = ability.name });
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

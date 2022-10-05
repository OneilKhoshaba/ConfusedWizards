using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Tag", menuName = "Tag Data", order = 2)]
public class EnemyTagsSO : ScriptableObject
{
    public string tagName;

    [TextArea (1,100)]
    public string tagDes;

}

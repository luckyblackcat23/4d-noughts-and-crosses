using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ObjectData", menuName = "ScriptableObjects/Object")]
public class ObjectSettings : ScriptableObject
{
    public string Name;
    public string Description;
    public int OsRequired;
    public int XsRequired;
    public Sprite ObjectSprite;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Dialogue
{
    public GameObject character;
    [TextArea(2, 8)]
    public string[] sentences;
}

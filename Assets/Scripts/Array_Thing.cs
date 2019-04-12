using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array_Thing : MonoBehaviour
{
    [Array_Thing_(new string[] { "Ben", "Jordy", "Stephen", "Sebastian"})]
    public string[] boyo = new string[4];

    
}
public class Array_Thing_Attribute : PropertyAttribute
{

    public readonly string[] names;

    public Array_Thing_Attribute(string[] names)
    { this.names = names; }

}
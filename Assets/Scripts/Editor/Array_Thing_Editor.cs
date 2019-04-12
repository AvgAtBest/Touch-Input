using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomPropertyDrawer(typeof(Array_Thing_Attribute))]
public class Array_Thing_Editor : PropertyDrawer
{

    public override void OnGUI(Rect rect, SerializedProperty property, GUIContent label)
    {
        try
        {
            int pos = int.Parse(property.propertyPath.Split('[', ']')[1]);
            //For objects, put ObjectFields. For property, PropetyField
            EditorGUI.PropertyField(rect, property, new GUIContent(((Array_Thing_Attribute)attribute).names[pos]));
        }
        catch
        {
            EditorGUI.PropertyField(rect, property, label);
        }
    }
}

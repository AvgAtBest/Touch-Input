using UnityEngine;
using UnityEditor;

public class Example_Editor_Window : EditorWindow
{

    public string myString = "This is a Text Field";
    Color colour;
    float alpha = 1f;
    [MenuItem("Window/Example")]

    public static void ShowWindow()
    {
        GetWindow<Example_Editor_Window>("Example");
    }
    private void OnGUI()
    {
        GUIStyle t = new GUIStyle(EditorStyles.textField);
        t.normal.textColor = colour;
        
        //Editor Window Code
        GUILayout.Label("My Label.", t);
        
        //Editable text value
        myString = EditorGUILayout.TextField("Text", myString, t);
        //Creates button
        if (GUILayout.Button("Test Button"))
        {
            Debug.Log("BUTTON");
        }
        colour = EditorGUILayout.ColorField("Colour", colour);
        if (GUILayout.Button("Yeet", EditorStyles.radioButton))
        {
            Debug.Log("tick");
        }
    }
    public void Awake()
    {
        colour = Color.red;
        colour.a = alpha;
    }

}

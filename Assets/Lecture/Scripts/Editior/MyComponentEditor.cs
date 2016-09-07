using UnityEngine;
using UnityEditor;
using System.Collections;


[CustomEditor(typeof(MyComponent))]
public class MyComponentEditor : Editor
{
    void OnEnable()
    {

    }


    public override void OnInspectorGUI()
    {
       // base.OnInspectorGUI();

        MyComponent myComponent = (MyComponent)target;
        myComponent.intVariable = EditorGUILayout.IntField("int variable", myComponent.intVariable);
        myComponent.floatVariable = EditorGUILayout.Slider("float variable", myComponent.floatVariable, 0f, 100f);
        myComponent.IntVar = EditorGUILayout.IntField("int Var", myComponent.IntVar);

        if(GUILayout.Button("Do Something") == true)
        {
            myComponent.DoSomething();
        }
        
    }

}

using UnityEngine;
using System.Collections;
using UnityEditor;

public class MidiTrackWindow : EditorWindow {

	
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(MidiTrackWindow),false,"My Window");
    }
    void OnGUI()
    {


        Rect rect;
        float titleHeight = 30f;
        float musicalScaleWidth = 60f;
        float timeHeight = 50f;

        rect = new Rect(0,0,position.width,30f);
        GUI.Box(rect, "");
        GUILayout.BeginArea(rect);
        GUILayout.EndArea();

        rect = new Rect(0, 30f, 50f, position.height - titleHeight);
        GUI.Box(rect, "");
        GUI.BeginGroup(rect);
        GUI.EndGroup();


        rect = new Rect(position.width * 0.75f, titleHeight, position.width * 0.25f, position.height - titleHeight);
        GUI.Box(rect, "");
        GUILayout.BeginArea(rect);
        GUILayout.EndArea();


        rect = new Rect(musicalScaleWidth, titleHeight, position.width - musicalScaleWidth - (position.width * 0.25f), timeHeight);
        GUI.Box(rect, "");
        GUI.BeginGroup(rect);
        GUI.EndGroup();



        rect = new Rect(musicalScaleWidth, titleHeight + timeHeight, position.width - musicalScaleWidth - (position.width * 0.25f), position.height - titleHeight - timeHeight);
        GUI.Box(rect, "");
        GUI.BeginGroup(rect);
        GUI.EndGroup();
       

        //create Tot;e Area

        //GUILayout.BeginArea()
    }



}

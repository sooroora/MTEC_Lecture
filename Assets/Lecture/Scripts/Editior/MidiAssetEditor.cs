using UnityEngine;
using System.Collections;

using UnityEditor;
using System.IO;


[CustomEditor(typeof(MidiAsset))]
public class MidiAssetEditor : Editor
{

    private bool _foldout = true;


    void OnEnable()
    {


    }

    public override void OnInspectorGUI()
    {
        MidiAsset midiAsset = (MidiAsset)target;

        GUILayout.Label("File Name" + Path.GetFileNameWithoutExtension(midiAsset.fileName));

        GUILayout.Label(string.Format("TotalTime : {0:f}", midiAsset.totalTime));
        

        EditorGUILayout.Foldout(_foldout, " Time Signiture");

        if(_foldout == true)
        {
            //EditorGUI.indentLevel++;
            GUILayout.Label(string.Format("PPQN : {0:f}", midiAsset.PPQN));
            GUILayout.Label(string.Format("Pulse : {0:f}", midiAsset.pulseTime));
            GUILayout.Label(string.Format("BPM : {0:f}", midiAsset.Bpm));
            GUILayout.Label(string.Format("Nemerator : {0:f}", midiAsset.nemerator));

            //EditorGUI.indentLevel--;
        }
        

        if(GUILayout.Button("Track Viewer") == true)
        {
            MidiTrackWindow.ShowWindow();
        }


    }




}
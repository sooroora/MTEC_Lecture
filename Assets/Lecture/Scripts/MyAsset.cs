using UnityEngine;
using System.Collections;

public class MyAsset : ScriptableObject {

    public int inVar = 0;
    public float floatVar = 0f;

    public void Revert()
    {
        inVar = 0;
        floatVar = 0.0f;
    }
}

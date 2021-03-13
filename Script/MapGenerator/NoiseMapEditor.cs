using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(MapDisplay), true), CanEditMultipleObjects]
public class NoiseMapEditor : Editor
{
    //public override void OnInspectorGUI()
    //{
    //    MapDisplay Script = (MapDisplay)target;
    //    base.OnInspectorGUI();
    //    if(Script.autoUpdata)
    //        Script.GenerateNoiseMap();
    //    if (GUILayout.Button("Generate"))
    //    {
    //        Script.GenerateNoiseMap();
    //    }
    //}
}

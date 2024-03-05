using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(AsbtractGenerator),true)]
public class RandomDungeonGeneratorEditor : Editor
{
    AsbtractGenerator genrator;

    private void Awake()
    {
        genrator = (AsbtractGenerator)target;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if(GUILayout.Button("Create Dungeon"))
        {
            genrator.GenerateDungeon();
        }
    }
}

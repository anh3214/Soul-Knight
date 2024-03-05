using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AsbtractGenerator : MonoBehaviour
{
    [SerializeField] protected TileMapVisualizer tileMapVisualizer;
    [SerializeField] protected Vector2Int startPosition = Vector2Int.zero;

    public void GenerateDungeon()
    {
        tileMapVisualizer.Clear();
        RunProceduralGenration();
    }

    protected abstract void RunProceduralGenration();
}

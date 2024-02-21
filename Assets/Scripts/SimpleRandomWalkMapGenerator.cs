using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SimpleRandomWalkMapGenerator : MonoBehaviour
{
    [SerializeField] protected Vector2Int startPosition = Vector2Int.zero;
    [SerializeField] private int interations = 10;
    [SerializeField] public int walkLenght = 10;
    [SerializeField] public bool startRandomlyEachIteration = true;


    [SerializeField] private TileMapVisualizer _tileMapVisualizer;


    public void RunProceduralGeneration()
    {
        HashSet<Vector2Int> floorPositions = RunRandomWalk();
        _tileMapVisualizer.Clear();
        _tileMapVisualizer.PaintFloorTiles(floorPositions);
    }

    protected HashSet<Vector2Int> RunRandomWalk()
    {
        var currenPosition = startPosition;
        HashSet<Vector2Int> florPositions = new HashSet<Vector2Int>();
        for (int  i = 0;  i < interations;  i++)
        {
            var path = ProveduralGenerationAlgorithms.SimpleRandomWolk(currenPosition, walkLenght);
            florPositions.UnionWith(path);
            if (startRandomlyEachIteration)
                currenPosition = florPositions.ElementAt(Random.Range(0,florPositions.Count));
        }
        return florPositions;
    }
}

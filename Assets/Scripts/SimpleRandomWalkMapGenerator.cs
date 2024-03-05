using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class SimpleRandomWalkMapGenerator : AsbtractGenerator
{
    [SerializeField] private SimpleRandomWalkSO randomWalkSO;

    protected override void RunProceduralGenration()
    {
        HashSet<Vector2Int> floorPositions = RunRandomWalk();
        tileMapVisualizer.Clear();
        tileMapVisualizer.PaintFloorTiles(floorPositions);
    }

    protected HashSet<Vector2Int> RunRandomWalk()
    {
        var currenPosition = startPosition;
        HashSet<Vector2Int> florPositions = new HashSet<Vector2Int>();
        for (int  i = 0;  i < randomWalkSO.interation;  i++)
        {
            var path = ProveduralGenerationAlgorithms.SimpleRandomWolk(currenPosition, randomWalkSO.walkLenght);
            florPositions.UnionWith(path);
            if (randomWalkSO.startRandomlyEachIteration)
                currenPosition = florPositions.ElementAt(Random.Range(0, florPositions.Count));
        }
        return florPositions;
    }
}

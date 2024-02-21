using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ProveduralGenerationAlgorithms
{
    public static HashSet<Vector2Int> SimpleRandomWolk(Vector2Int startPosition, int walkLenght)
    {
        HashSet<Vector2Int> path = new HashSet<Vector2Int>();
        
        path.Add(startPosition);

        var prev = startPosition;

        for (int i = 0; i < walkLenght; i++)
        {
            var newPositon = prev + Direction2D.GetRandomCardinalDirection();
            path.Add(newPositon);
            prev = newPositon;
        }
        return path;
    }
}

public static class Direction2D
{
    public static List<Vector2Int> cardinalDirectionList = new List<Vector2Int>
    {
        new Vector2Int(0,1), // Up
        new Vector2Int(1,0), // Right
        new Vector2Int(0,-1), // Down
        new Vector2Int(-1,0), // Left
    };

    public static Vector2Int GetRandomCardinalDirection()
    {
        return cardinalDirectionList[Random.Range(0, cardinalDirectionList.Count)];
    }
}

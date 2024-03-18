using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements.Experimental;

public class LevelManager : MonoBehaviour
{
    public GameObject player;
    public GameObject gatePrefab;
    public float distanceToPlayer = 10.0f;

    private GameObject? gate = null;

    void Update()
    {
        int enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        player = GameObject.FindGameObjectWithTag("Player");
        if (enemyCount == 0 && gate == null)
        {
            gate = Instantiate(gatePrefab, player.transform.position + new Vector3(2, 0, 0), Quaternion.identity);
        }
    }
}

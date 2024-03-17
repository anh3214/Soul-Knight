using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private GameObject gameOver;
    public void GameOver()
    {
        gameOver.SetActive(true);

        Time.timeScale = 0;
    }
    public void ResetButton()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void ExitButton()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}

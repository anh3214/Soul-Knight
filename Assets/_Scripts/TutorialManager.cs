using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    private void Awake()
    {
        if (!PlayerPrefs.HasKey("firstTime") || PlayerPrefs.GetInt("firstTime") != 69)
        {
            PlayerPrefs.SetInt("firstTime", 69);
            PlayerPrefs.Save();
        }
        else if (PlayerPrefs.GetInt("firstTime") == 69)
        {
            SceneManager.LoadSceneAsync(1);
        }
    }

}

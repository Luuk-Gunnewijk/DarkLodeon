using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Manger : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Start_Menu");
    }

    public void StartPegga_Pig()
    {
        SceneManager.LoadScene("Level_01");
    }

    public void StartNijntje()
    {
        SceneManager.LoadScene("Level_07");
    }
}

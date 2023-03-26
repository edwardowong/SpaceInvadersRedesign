using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadStartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void LoadLevelSelectionMenu()
    {
        SceneManager.LoadScene("LevelSelection");
    }

    public void LoadShopMenu()
    {
        SceneManager.LoadScene("Shop");
    }

    public void LoadSettingsMenu()
    {
        SceneManager.LoadScene("Settings");
    }

    public void LoadDailyMissionsMenu()
    {
        SceneManager.LoadScene("DailyMissions");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

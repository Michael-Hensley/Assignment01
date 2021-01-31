using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }

    public void toMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void toSettings()
    {
        SceneManager.LoadScene(1);
    }

    public void quitApp()
    {
        Debug.Log("Application Exited");
        Application.Quit();
    }

    public void toSecretLevel()
    {
        SceneManager.LoadScene(6);
    }

}

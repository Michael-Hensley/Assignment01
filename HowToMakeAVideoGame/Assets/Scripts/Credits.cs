using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void Quit ()
    {
        Debug.Log("Application exited");
        Application.Quit();
    }

    public void toMenu()
    {
        SceneManager.LoadScene(0);
    }
}
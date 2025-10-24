using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    // Load the Home Scene
    public void LoadHomeScene()
    {
        Debug.Log("home");
        SceneManager.LoadScene("HomeScene");  // replace with your actual scene name
    }

    // Load EX1 Scene
    public void LoadEX1Scene()
    {
        Debug.Log("EX1");
        SceneManager.LoadScene("EX1Scene");
    }

    // Load EX2 Scene
    public void LoadEX2Scene()
    {
        Debug.Log("EX2");
        SceneManager.LoadScene("EX2Scene");
    }

    // Load Credits Scene
    public void LoadCreditsScene()
    {
        Debug.Log("Credits");
        SceneManager.LoadScene("CreditsScene");
    }

    // Exit the Application
    public void ExitGame()
    {
        Debug.Log("Exiting Game");
        Application.Quit();
    }
}
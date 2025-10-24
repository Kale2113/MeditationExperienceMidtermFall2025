using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    
    public void LoadHomeScene()
    {
        Debug.Log("home");
        SceneManager.LoadScene("HomeScene");  
    }

    
    public void LoadEX1Scene()
    {
        Debug.Log("EX1");
        SceneManager.LoadScene("EX1Scene");
    }

    
    public void LoadEX2Scene()
    {
        Debug.Log("EX2");
        SceneManager.LoadScene("EX2Scene");
    }

    
    public void LoadCreditsScene()
    {
        Debug.Log("Credits");
        SceneManager.LoadScene("CreditsScene");
    }

    
    public void ExitGame()
    {
        Debug.Log("Exiting Game");
        Application.Quit();
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartSingleMedium()
    {
        SceneManager.LoadScene("Level1");
    }

    public void StartSingleEasy()
    {
        SceneManager.LoadScene("Level1Easy");
    }

    public void StartSingleHard()
    {
        SceneManager.LoadScene("Level1Hard");
    }


    public void StartCoop()
    {
        SceneManager.LoadScene("CoopLevel1");
    }

    public void StartCoopEasy()
    {
        SceneManager.LoadScene("CoopLevel1Easy");
    }

    public void StartCoopHard()
    {
        SceneManager.LoadScene("CoopLevel1Hard");
    }


    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainM()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

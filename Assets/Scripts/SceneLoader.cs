using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public GuessCounter guessCounter;

    public int arvausValue;

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 1)
        {
            SceneManager.LoadScene(currentSceneIndex + 2);
            Debug.Log(currentSceneIndex);
        }
        else
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
            Debug.Log(currentSceneIndex);
        }
    }

    public void LoadNextSceneStop()
    {
        arvausValue = ValueHolder.GuessCounter;
        if (arvausValue != 0)
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            Debug.Log(currentSceneIndex);
            SceneManager.LoadScene(currentSceneIndex + 1);
            ValueHolder.ValueOfGuess = -1;
        }
        else
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            Debug.Log(currentSceneIndex);
            SceneManager.LoadScene(currentSceneIndex + 1);
            ValueHolder.ValueOfGuess = -2;
        }
    }

    public void LoadMainScreen()
    {
        SceneManager.LoadScene(0);
    }

    public void CloseGame()
    {
        Application.Quit();
    }

    public void LoadCreditScreen()
    {
        SceneManager.LoadScene(4);
    }
}

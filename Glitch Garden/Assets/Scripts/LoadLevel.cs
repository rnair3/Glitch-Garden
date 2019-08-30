using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    [SerializeField] int waitForTime = 4;
    int currentSceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentSceneIndex == 0)
        {
            StartCoroutine(GoToStartScene());
        }
    }

    IEnumerator GoToStartScene()
    {
        yield return new WaitForSeconds(waitForTime);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(++currentSceneIndex);
    }

    public void GameOverScene()
    {
        SceneManager.LoadScene("Game Over");
    }

    public void RestartScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void MainMenuScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start Scene");
    }

    public void LoadOptionsScene()
    {
        SceneManager.LoadScene("Options");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

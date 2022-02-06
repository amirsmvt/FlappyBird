using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartTheGame : MonoBehaviour
{
    public void ChangeScene(string scene = "")
    {
        SceneManager.LoadScene(sceneName: scene);
    }
    public void Exit()
    {
        Application.Quit();
    }
}

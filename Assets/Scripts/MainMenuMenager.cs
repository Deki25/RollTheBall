using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuMenager : MonoBehaviour
{
    public void Play(string loadScene)
    {
        SceneManager.LoadScene(loadScene);
    }

    public void Shop(string loadScene)
    {
        SceneManager.LoadScene(loadScene);
    }

    public void Options(string loadScene)
    {
        SceneManager.LoadScene(loadScene);
    }

    public void Quit()
    {
        Application.Quit();
    }
}

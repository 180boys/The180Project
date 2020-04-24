using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void ConnorLevel()
    {
        SceneManager.LoadScene("LevelDesign", LoadSceneMode.Single);

    }

    public void EvanLevel()
    {
        SceneManager.LoadScene("EvansBonusLevel", LoadSceneMode.Single);

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void Quit()
    {
        Debug.Log("Ded");
        Application.Quit();
    }
}


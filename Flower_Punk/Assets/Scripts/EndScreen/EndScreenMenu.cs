using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreenMenu : MonoBehaviour
{

    public void MainMenu()
    {

        SceneManager.LoadScene("MainMenu");

    }

    public void Quit()
    {
        Application.Quit();
    }
}

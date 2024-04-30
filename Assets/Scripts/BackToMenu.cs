using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public void StartAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);

    }

    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEndrd = false;
    public float restartDelay = 1f;

    public GameObject complateLevelUI;
    public void CompleteLevel1()
    {
        complateLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if (gameHasEndrd == false)
        {
            gameHasEndrd = true;
            Debug.Log("game over");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}

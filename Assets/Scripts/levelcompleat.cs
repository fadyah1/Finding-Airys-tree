
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelcompleat : MonoBehaviour
{
    // Start is called before the first frame update
    void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class credits : MonoBehaviour
{

    public void Quit()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void Restart()
    {
        Debug.Log("Restart Game");
        SceneManager.LoadScene("level1");
    }
 
}

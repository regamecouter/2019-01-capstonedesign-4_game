using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public void Startgame()
    {
        SceneManager.LoadScene("difficulty");
    }
    public void selecteasy()
    {
        SceneManager.LoadScene("easy");
    }
    public void selectnormal()
    {
        SceneManager.LoadScene("normal");
    }
    public void selecthard()
    {
        SceneManager.LoadScene("hard");
    }
public void GotoTitle()
    {
        SceneManager.LoadScene("Title");
    }
}

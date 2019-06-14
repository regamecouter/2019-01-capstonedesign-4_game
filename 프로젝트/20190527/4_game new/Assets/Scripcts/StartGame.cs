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
        SceneManager.LoadScene("Map1");
    }
    public void selectnormal()
    {
        SceneManager.LoadScene("Map2");
    }
    public void selecthard()
    {
        SceneManager.LoadScene("Map3");
    }
public void GotoTitle()
    {
        SceneManager.LoadScene("Title");
    }
}

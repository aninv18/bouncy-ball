using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void Menu_game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        Debug.Log("Menu");
    }

    public void Menu_options()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("options");
    }

    public void Options_game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Menu");
    }

    public void Options_back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Debug.Log("Menu");
    }

    public void Mainmenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
        Debug.Log("Menu");
    }
    public void Next_Level()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Debug.Log("Menu");
    }
}

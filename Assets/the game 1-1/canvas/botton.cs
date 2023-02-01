using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botton : MonoBehaviour
{
    

    public void Game() 
    {
        SceneManager.LoadScene(1);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void Dead()
    {
        SceneManager.LoadScene(2);
    }
    public void Win()
    {
        SceneManager.LoadScene(3);
    }

}

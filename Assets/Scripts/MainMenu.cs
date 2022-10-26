using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Class to define operations on basic UI components
public class MainMenu : MonoBehaviour
{
    //Plays game
    public void PlayGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    //Quit Game
    public void QuitGame()
    {
        //If using on editor, nice to see on console
        print("QUIT GAME");
        Application.Quit();
    }

    //Return to home
    public void ReturnHome()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}

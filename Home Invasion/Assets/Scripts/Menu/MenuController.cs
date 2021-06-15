using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    //Start the game
    public void PlayGame()
    {
        Debug.Log("Pick Level");
        SceneManager.LoadScene("PickLevel");
    }

    //Open settings
    public void OpenSettings()
    {
        Debug.Log("Open Settings");
    }

    //Quit game
    public void QuitGame()
    {
        Debug.Log("Quit game");
        Application.Quit();
    }
}

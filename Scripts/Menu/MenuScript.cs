using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void Levels()
    {

        //levels
        SceneManager.LoadScene(1);

    }

    public void Endless()
    {
        Debug.Log("Endless Mode");
    }

    public void Options()
    {
        Debug.Log("Option Stuffs");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("The person quit idiot");
    }

}

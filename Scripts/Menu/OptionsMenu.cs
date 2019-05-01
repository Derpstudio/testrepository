using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour {

    public void ResetData()
    {

       // reset data to defaults etc

       GameObject GameManager = GameObject.Find("GameManager");
       GameManagerScript GMScript = GameManager.GetComponent<GameManagerScript>();
       GMScript.LevelsBeat = 0;
        GMScript.totalMedals = 0;
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}

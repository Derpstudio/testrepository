using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteMenu : MonoBehaviour {

    public int nextlevelid;

    public void NextLevel()
    {
       
        SceneManager.LoadScene(nextlevelid);

    }

    public void LevelSelect()
    {
        SceneManager.LoadScene(1);
    }
}

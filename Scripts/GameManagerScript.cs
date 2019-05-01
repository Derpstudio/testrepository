using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {
    public int LevelsBeat;
    public int totalMedals;



    //high score tables to count gold
    public int level1highscore;
    public int level2highscore;
    public int level3highscore;
    public int level4highscore;
    public int level5highscore;
    public int level6highscore;
    public int level7highscore;
    public int level8highscore;
    public int level9highscore;
    public int level10highscore;



    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    void Start()
    {
        //load the game from boot up
    }


    public void SaveGame()
    {

        //save the game etc, (hopefully) can get called upon level completion for each level.
    }

    
  
}

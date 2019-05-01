using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalColision : MonoBehaviour {

    public GameObject endText;
    public GameObject button1;
    public GameObject button2;

	public int levelCount;

    void Update()
	{

	 //coins from level
        GameObject Player = GameObject.Find("Player");
        CoinCounter CoinScript = Player.GetComponent<CoinCounter>();

        //gamemanager

        GameObject GameManager = GameObject.Find("GameManager");
        GameManagerScript ManagerScript = Player.GetComponent<GameManagerScript>();


	}



    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.tag == "Player")
        {
            endText.SetActive(true);
            button1.SetActive(true);
            button2.SetActive(true);
        }

        ManageSave();


    }

    void ManageSave()
    {
       

//out of ide devlog: Changed the levelcount var to the goalscript, changed the getcomponent to Update() (that's probably why it wasnt working lol)


         switch (levelCount)
        {
             case 1:
                 if (CoinScript.coinsCollected > ManagerScript.level1highscore)
                 {
                     CoinScript.coinsCollected = ManagerScript.level1highscore;

                  //to do : implement saving in the Manager script and loading too, find out how to call voids from other scripts, then implement data reset in the 
                  //options menu and after that maybe find out how to not colide with coins and then make levels. Important priorities first guys
                 }

                break;
        }

    }
}

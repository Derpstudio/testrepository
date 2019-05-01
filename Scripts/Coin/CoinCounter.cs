using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour {

    public Text coinText;
    public int coinsCollected = 0;
    public int maxCoin;


    void Update()
    {

        

        SetcoinText();
        


    }

    void SetcoinText()
    {
        coinText.text = "Coins " + coinsCollected.ToString() + "/ " + maxCoin.ToString();
        
    }



     void OnCollisionEnter2D(Collision2D obj)
      {
         if (obj.gameObject.tag == "coin")
          {


             coinsCollected = coinsCollected + 1;
    
    
        }
       }




}

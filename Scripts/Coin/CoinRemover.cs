using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRemover : MonoBehaviour
{

    

    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.tag == "Player")
        {
            

            StartCoroutine("Destroy");
        }
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(0.01f);
        Destroy(gameObject);

    }
}

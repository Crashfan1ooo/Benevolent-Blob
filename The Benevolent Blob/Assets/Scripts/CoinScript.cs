using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {
        //Adds a point when collected and destroys the coin
        CoinScoreKeeper.collectibleNumber += 1;
        Destroy(gameObject);
    }

}

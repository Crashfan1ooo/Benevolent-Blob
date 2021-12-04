using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    public CharacterScript theCharacterScript;
    GameObject theMainPlayer;
    private void Start()
    {
        theMainPlayer = GameObject.Find("MainPlayer");
        theCharacterScript = (CharacterScript)theMainPlayer.GetComponent(typeof(CharacterScript));
    }

    private void OnTriggerEnter(Collider other)
    {
        //Adds a point when collected and destroys the coin
        CoinScoreKeeper.collectibleNumber += 1;
        theCharacterScript.CoinCollected();
        Destroy(gameObject);
        
    }

}

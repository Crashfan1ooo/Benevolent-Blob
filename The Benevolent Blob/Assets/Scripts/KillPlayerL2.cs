using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayerL2 : MonoBehaviour
{
    public int Respawn;

    //stuff for Coin management
    public GameObject CoinChecker;
    private CoinScoreKeeper coinScript;

    // Start is called before the first frame update
    void Start()
    {
        CoinChecker = GameObject.Find("UI Hub");
        coinScript = CoinChecker.GetComponent<CoinScoreKeeper>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            CoinScoreKeeper.collectibleNumber = CoinScoreKeeper.lastCoins;
            SceneManager.LoadScene(Respawn);
        }
    }
}

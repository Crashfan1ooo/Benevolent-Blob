using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayerL3 : MonoBehaviour
{ 
    public GameObject CoinChecker2;
    public CoinScoreKeeper coinScript2;
    public int Respawn;
    // Start is called before the first frame update
    void Start()
    {
        CoinChecker2 = GameObject.Find("UI Hub");
        coinScript2 = CoinChecker2.GetComponent<CoinScoreKeeper>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CoinScoreKeeper.collectibleNumber = CoinScoreKeeper.lastCoins;
            SceneManager.LoadScene(Respawn);
        }
    }
}

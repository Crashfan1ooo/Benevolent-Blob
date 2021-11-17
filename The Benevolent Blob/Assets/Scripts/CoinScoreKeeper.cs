using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinScoreKeeper : MonoBehaviour
{

    public GameObject collectibleText;

    public static int collectibleNumber;

    public static int lastCoins;

    private bool coinProcess2 = false;
    private bool coinProcess3 = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level 2"))
        {
            if (coinProcess2 == false)
            {
                SceneChecker();
                coinProcess2 = true;
            }
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level 3"))
        {
            if (coinProcess3 == false)
            {
                SceneChecker();
                coinProcess3 = true;
            }
        }

        //Displays the current number of coins.
        collectibleText.GetComponent<Text>().text = "Coins: " + collectibleNumber;

    }

    void SceneChecker()
    {
        lastCoins = collectibleNumber;

    }

}


    


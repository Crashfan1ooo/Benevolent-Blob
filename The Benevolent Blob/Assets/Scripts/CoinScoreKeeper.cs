using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinScoreKeeper : MonoBehaviour
{

    public GameObject collectibleText;

    public  static int collectibleNumber;

    public static int lastCoins;

    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;
        
        if (sceneName == "Level 2")
        {
            lastCoins = collectibleNumber;
        }

        else if (sceneName == "Level 3")
        {
            lastCoins = collectibleNumber;
        }
    }

    // Update is called once per frame
    void Update()
    {

        //Displays the current number of coins.
        collectibleText.GetComponent<Text>().text = "Coins: " + collectibleNumber;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScoreKeeper : MonoBehaviour
{

    public GameObject collectibleText;

    public static int collectibleNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Displays the current number of treasures.
        collectibleText.GetComponent<Text>().text = "Treasure: " + collectibleNumber;

     

    }
}

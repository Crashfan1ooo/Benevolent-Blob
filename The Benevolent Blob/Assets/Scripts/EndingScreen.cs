using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingScreen : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(CoinScoreKeeper.collectibleNumber == 0)
        {
            SceneManager.LoadScene("Title");
        }

        else if(CoinScoreKeeper.collectibleNumber >= 25 && CoinScoreKeeper.collectibleNumber <=49)
        {
            SceneManager.LoadScene("Ending1");
        }
    }
}

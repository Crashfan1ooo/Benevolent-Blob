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
            SceneManager.LoadScene("Ending0");
        }

        else if(CoinScoreKeeper.collectibleNumber >= 1 && CoinScoreKeeper.collectibleNumber <=49)
        {
            SceneManager.LoadScene("Ending1");
        }

        else if (CoinScoreKeeper.collectibleNumber >= 50 && CoinScoreKeeper.collectibleNumber <= 99)
        {
            SceneManager.LoadScene("Ending2");
        }

        else if (CoinScoreKeeper.collectibleNumber >= 100 && CoinScoreKeeper.collectibleNumber <= 149)
        {
            SceneManager.LoadScene("Ending3");
        }

        else if (CoinScoreKeeper.collectibleNumber == 150)
        {
            SceneManager.LoadScene("Ending4");
        }
    }
}

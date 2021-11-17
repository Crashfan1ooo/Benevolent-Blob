using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{

    public GameObject canvasWithCoins;

    private void Start()
    {
        canvasWithCoins = GameObject.Find("CanvasCoins");
    }

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Ending0"))
        {
            canvasWithCoins.SetActive(false);
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Ending1"))
        {
            canvasWithCoins.SetActive(false);
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Ending2"))
        {
            canvasWithCoins.SetActive(false);
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Ending3"))
        {
            canvasWithCoins.SetActive(false);
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Ending4"))
        {
            canvasWithCoins.SetActive(false);
        }
    }

}


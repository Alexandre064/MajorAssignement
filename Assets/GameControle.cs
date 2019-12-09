using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControle : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameControle instance;
    public GameObject gameOverText;
    public GameObject gameWinText;
    public bool gameOver = false;

    void Awake()
    {
        if(instance == null){
            instance = this;
        }else if(instance != this){
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver == true && Input.GetKeyUp(KeyCode.Space))
        {
            GameObject.Find("Panel").GetComponent<GameCommand>().BackToMainMenu();
        }
    }
    public void gameFinishLoose()
    {
        gameOverText.SetActive(true);
        GameObject.Find("Panel").GetComponent<GameCommand>().paused = true;
        gameOver = true;
    }
    public void gameFinishWin(){
        gameWinText.SetActive(true);
        GameObject.Find("Panel").GetComponent<GameCommand>().paused = true;
        gameOver = true;
    }
}

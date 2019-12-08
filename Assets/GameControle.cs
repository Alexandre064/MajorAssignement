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
            brick.nbrBrick = 13;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void gameFinishLoose()
    {
        gameOverText.SetActive(true);
        Time.timeScale = 0;
        gameOver = true;
    }
    public void gameFinishWin(){
        gameWinText.SetActive(true);
        Time.timeScale = 0;
        gameOver = true;
    }
}

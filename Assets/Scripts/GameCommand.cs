using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCommand : MonoBehaviour
{
    public bool paused = false;
    public GameObject text;
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this);
        paused = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            paused = !paused;
            if (paused)
            {
                text.SetActive(true);
            }
            else
            {
                text.SetActive(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            BackToMainMenu();
        }

        Time.timeScale = paused ? 0 : 1;
    }

    public void BackToMainMenu()
    {
        DestroyGameObject();
        SceneManager.LoadScene("MainMenu");
    }

    public void DestroyGameObject()
    {
        Destroy(GameObject.Find("Panel"));
        Destroy(GameObject.Find("Ball"));
    }
}

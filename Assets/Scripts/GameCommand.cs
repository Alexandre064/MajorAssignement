using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCommand : MonoBehaviour
{
    public bool paused = false;
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
            
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Destroy(GameObject.Find("Panel"));
            Destroy(GameObject.Find("Ball"));
            SceneManager.LoadScene("MainMenu");
        }

        Time.timeScale = paused ? 0 : 1;
    }
}

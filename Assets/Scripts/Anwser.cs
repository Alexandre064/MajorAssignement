using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Anwser : MonoBehaviour
{

    void OnMouseDown()
    {
        string toto = GameObject.Find("CanvasQuizz").GetComponent<Quizz>().Anwser;
        if (GameObject.Find("CanvasQuizz").GetComponent<Quizz>().Anwser == transform.GetChild(0).GetComponent<TextMesh>().text)
        {
            Debug.Log("Won");
            GameObject.FindWithTag("ui").GetComponent<UiManager>().IncrementScore(10);
        }
        else
        {
            Debug.Log("Lose");
            GameObject.FindWithTag("ui").GetComponent<UiManager>().IncrementScore(-5);
        }
        //Go to main scene
        SceneManager.UnloadSceneAsync("Quizz");
        GameObject.Find("Panel").GetComponent<GameCommand>().paused = false;
    }

}

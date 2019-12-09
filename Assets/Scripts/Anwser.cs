using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Anwser : MonoBehaviour
{

    void OnMouseDown()
    {
        string toto = GameObject.Find("Canvas").GetComponent<Quizz>().Anwser;
        if (GameObject.Find("Canvas").GetComponent<Quizz>().Anwser == transform.GetChild(0).GetComponent<TextMesh>().text)
        {
            Debug.Log("Won");
            //GameObject.Find("Canvas").GetComponent<Quizz>().ui.score+=2;
        }
        else
        {
            Debug.Log("Lose");
            //nothing happens?
        }
        //Go to main scene
        int nb;
        nb = Random.Range(0, 3);
        // GameObject.Find("Canvas").GetComponent<Quizz>().askQuestion(nb);
        SceneManager.LoadScene("Game");
        //SceneManager.UnloadSceneAsync("Quizz");
    }

}

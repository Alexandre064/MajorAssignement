﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Anwser : MonoBehaviour
{
    void OnMouseDown()
    {
        if(GameObject.Find("Canvas").GetComponent<Quizz>().Anwser == transform.GetChild(0).GetComponent<TextMesh>().text)
        {
            Debug.Log("Won");
            GameObject.Find("Canvas").GetComponent<Quizz>().score++;
        }
        else
        {
            Debug.Log("Lose");
            //nothing happens?
        }
        //Go to main scene
        SceneManager.LoadScene("Game");
    }

}

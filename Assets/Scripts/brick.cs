﻿using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class brick : MonoBehaviour
{
    // Start is called before the first frame update
    public UiManager ui;
    
    private Quizz quizz;
    void Start()
    {
        ui = GameObject.FindWithTag("ui").GetComponent<UiManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag == "Ball")
        {
            Regex regex = new Regex(@"BrickQuizer \(\d\)");
            Match match = regex.Match(gameObject.name);
<<<<<<< Updated upstream
            if (match.Success)
            {
                //Debug.Log(match.Value);
                bool pause = GameObject.Find("Panel").GetComponent<GameCommand>().paused;
                pause = !pause;
                Time.timeScale = pause ? 0 : 1;
                SceneManager.LoadScene("Quizz", LoadSceneMode.Additive);
                //Scene nextScene = SceneManager.GetSceneByName("Quizz");
                //SceneManager.SetActiveScene(nextScene);

=======
            if(match.Success){
                //quizz = FindObjectOfType<Quizz>();                
                //quizz.currentQuiz();
                SceneManager.LoadSceneAsync("Quizz");
>>>>>>> Stashed changes
            }
            ui.IncrementScore();            
            Destroy(gameObject);
        }
    }
}

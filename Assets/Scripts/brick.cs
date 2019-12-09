using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.SceneManagement;

public class brick : MonoBehaviour
{
    // Start is called before the first frame update
    public UiManager ui;
    public static int nbrBrick = 13;
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
            nbrBrick--;
            
            Regex regex = new Regex(@"BrickQuizer \(\d\)");
            Match match = regex.Match(gameObject.name);
            if (match.Success)
            {
                //Debug.Log(match.Value);
                GameObject.Find("Panel").GetComponent<GameCommand>().paused = true;
                SceneManager.LoadSceneAsync("Quizz",LoadSceneMode.Additive);
                //Scene nextScene = SceneManager.GetSceneByName("Quizz");
                //SceneManager.SetActiveScene(nextScene);

            }                    
            ui.IncrementScore();            
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quizz : MonoBehaviour
{
    private Text textQuestion;
    private TextMesh textRep1;
    private TextMesh textRep2;
    private TextMesh textRep3;
    private TextMesh textRep4;
    public string Anwser;

    private int randNb;
    string[] QuizzList = new string[7];
<<<<<<< Updated upstream
=======
    public int score = 0;
    private Text textScore;

    int currentQuizNumber = 0;
>>>>>>> Stashed changes
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(currentQuizNumber);
        //Components
        textQuestion = GameObject.Find("TextQuestion").GetComponent<Text>();

        textRep1 = GameObject.Find("TxtRep1").GetComponent<TextMesh>();
        textRep2 = GameObject.Find("TxtRep2").GetComponent<TextMesh>();
        textRep3 = GameObject.Find("TxtRep3").GetComponent<TextMesh>();
        textRep4 = GameObject.Find("TxtRep4").GetComponent<TextMesh>();

        //Adding questions to quizz
        QuizzList[0] = "What is our teacher name?,Juan,Philip,Roman,Louis,Roman";
        QuizzList[1] = "6 x 4?,8,24,10,42,24";
        QuizzList[2] = "What is the most common tree in Estonia?,1,2,3,4,1";
        QuizzList[3] = "What is the most common tree in Estonia?,1,2,3,4,1";
        QuizzList[4] = "What is the most common tree in Estonia?,1,2,3,4,1";
        QuizzList[5] = "What is the most common tree in Estonia?,1,2,3,4,1";
        QuizzList[6] = "What is the most common tree in Estonia?,1,2,3,4,1";

        randNb = Random.Range(0, 2);
        askQuestion(randNb);
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream

=======
        //textScore.text = "score: " + score;
>>>>>>> Stashed changes
    }

    public void askQuestion(int nb)
    {
        string[] col = QuizzList[nb].Split(',');
        textQuestion.text = col[0];
        textRep1.text = col[1];
        textRep2.text = col[2];
        textRep3.text = col[3];
        textRep4.text = col[4];
        Anwser = col[5];

    }
    public void currentQuiz(){
        Debug.Log("tto");
        //currentQuizNumber = value;
    }
}

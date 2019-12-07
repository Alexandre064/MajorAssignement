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
    string[] QuizzList = new string[2];
    public int score = 0;
    private Text textScore;
    
    // Start is called before the first frame update
    void Start()
    {
        //Components
        textQuestion = GameObject.Find("TextQuestion").GetComponent<Text>();

        textRep1 = GameObject.Find("TxtRep1").GetComponent<TextMesh>();
        textRep2 = GameObject.Find("TxtRep2").GetComponent<TextMesh>();
        textRep3 = GameObject.Find("TxtRep3").GetComponent<TextMesh>();
        textRep4 = GameObject.Find("TxtRep4").GetComponent<TextMesh>();

        textScore = GameObject.Find("TextScore").GetComponent<Text>();

        //Adding questions to quizz
        QuizzList[0] = "What is our teacher name?,Juan,Philip,Roman,Louis,Roman";
        QuizzList[1] = "6 x 4?,8,24,10,42,24";
        QuizzList[2] = "What is the most common tree in Estonia?, ";
        QuizzList[3] = "";
        QuizzList[4] = "";
        QuizzList[5] = "";
        QuizzList[6] = "";

        randNb = Random.Range(0, QuizzList.Length);
        askQuestion(randNb);
    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = "score: " + score;
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
}

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
    
    // Start is called before the first frame update
    void Start()
    {
        //Components
        textQuestion = GameObject.Find("TextQuestion").GetComponent<Text>();

        textRep1 = GameObject.Find("TxtRep1").GetComponent<TextMesh>();
        textRep2 = GameObject.Find("TxtRep2").GetComponent<TextMesh>();
        textRep3 = GameObject.Find("TxtRep3").GetComponent<TextMesh>();
        textRep4 = GameObject.Find("TxtRep4").GetComponent<TextMesh>();

        //Adding questions to quizz
        QuizzList[0] = "What is our teacher name?,Juan,Philip,Roman,Louis,Roman";
        QuizzList[1] = "6 x 4?,8,24,10,42,24";
        QuizzList[2] = "Did you learn anything in Roman class?,Which one?,Yeh sure,Hell no,Who's Roman?,Yeh sure";
        QuizzList[3] = "Which game engine did we use for this game?,UE4,Unity,JMonkeyEngine,CryEngine,Unity";
        QuizzList[4] = "What is the size of estonian forests?,50%,30%,75%,40%,50%";
        QuizzList[5] = "Select the city which is not Estonian,Tartu,Tallinn,Pärnu,Turku,Turku";
        QuizzList[6] = "What lake is the biggest one?,Ülemiste,Saadjärv,Peïpous,Võrtsjärv,Peïpous";

        randNb = Random.Range(0, 6);
        askQuestion(randNb);
    }

    // Update is called once per frame
    void Update()
    {

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

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
    string[] QuizzList = new string[10];
    
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
        QuizzList[2] = "When was the formal independence of Estonia?,20 August 1991,14 June 1818,9 November 1989,1 January 1990,20 August 1991";
        QuizzList[3] = "Which game engine did we use for this game?,UE4,Unity,VisualStudio,CryEngine,Unity";
        QuizzList[4] = "What is the size of estonian forests?,50%,30%,75%,40%,50%";
        QuizzList[5] = "Select the city which is not Estonian,Tartu,Tallinn,Pärnu,Turku,Turku";
        QuizzList[6] = "What lake is the biggest one?,Ülemiste,Saadjärv,Peïpous,Võrtsjärv,Peïpous";
        QuizzList[7] = "Who is Estonian Prime Minister?,Mart Helme,Siim Kallas,Jüri Ratas,I don't know,Jüri Ratas";
        QuizzList[8] = "How populous is Estonia?,1 319 133,1 000 874,574 215,at least 1,1 319 133";
        QuizzList[9] = "Is Estonia part of the EU?,Yes,No,Maybe,I dont know,Yes";

        randNb = Random.Range(0, QuizzList.Length);
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

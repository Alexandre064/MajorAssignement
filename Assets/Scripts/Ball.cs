using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    public int score = 0;
    public TMP_Text ScoreUI;

    public Rigidbody2D rb;
    bool gameStarted = false;

    void Start()
    { 

    }
    void Update(){
        if(Input.GetKeyUp(KeyCode.Space)&& gameStarted == false){
            transform.SetParent(null);
            rb.isKinematic = false;
            rb.AddForce(new Vector2(speed,speed));
            gameStarted = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        /*
        if (collision.gameObject.name == "SideWallB")
        {
            score = 0;  //lose,make new scene
        }
        else if (collision.gameObject.name != "Bumper" 
            && collision.gameObject.name != "SideWallR" 
            && collision.gameObject.name != "SideWallL" 
            && collision.gameObject.name != "SideWallT" )
        {
            collision.gameObject.SetActive(false);
            ScoreUI.text = (++score).ToString();
        }
        */
    }
}

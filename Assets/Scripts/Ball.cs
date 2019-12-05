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

    void Start()
    {
        float x = (Random.Range(0, 2) == 0) ? -1 : 1; //init movement vector path
        float y = (Random.Range(0, 2) == 0) ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector3(x, y, 0);
        GetComponent<Rigidbody>().velocity *= speed; //init speed
    }

    private void OnCollisionEnter(Collision collision)
    {
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
    }
}

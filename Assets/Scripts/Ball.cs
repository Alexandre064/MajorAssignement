using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public float force;

    public Rigidbody2D rb;
    bool gameStarted = false;
    int nbrBrick = 13;
private AudioSource source { get { return GetComponent<AudioSource>(); } }
    public AudioClip simpleBrickSound;
    public AudioClip quizeBrickSound;

    void Start()
    { 
        gameObject.AddComponent<AudioSource>();
        source.playOnAwake = false;
    }
    void Update(){
        if(Input.GetKeyUp(KeyCode.Space)&& gameStarted == false){
            transform.SetParent(null);
            rb.isKinematic = false;
            rb.AddForce(new Vector2(force,force));
            gameStarted = true;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "BrickQuizer")
        {
            Debug.Log("okokok");
            source.clip = quizeBrickSound;
            source.PlayOneShot(quizeBrickSound);
        }else{
            source.clip = simpleBrickSound;
            source.PlayOneShot(simpleBrickSound);
        }


        if(collision.gameObject.tag == "Finish")
        {
            brick.nbrBrick = 13;
            GameControle.instance.gameFinishLoose();
        }
        else if(brick.nbrBrick == 0)
        {
            brick.nbrBrick = 13;
            GameControle.instance.gameFinishWin();
        }
        //rb.AddForce(new Vector2(0,force));        
        if (rb.velocity.x == 0)
        {
            rb.AddForce(new Vector2(force, 0));
        }
        if (rb.velocity.y == 0)
        {
            rb.AddForce(new Vector2(0, force));
        }
    }
}

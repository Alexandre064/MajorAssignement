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
    public AudioClip soundRebond;
    public AudioClip soundQuize;
    private AudioSource audi;

    void Start()
    { 
        audi = GetComponent<AudioSource>();
        audi.playOnAwake = false;
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
        //Debug.Log(rb.velocity);
        //rb.AddForce(new Vector2(0,force));
        if(collision.gameObject.tag == "quizer")
        {
            audi.clip = soundQuize;
            audi.PlayOneShot(soundQuize);
        }else{
            audi.clip = soundRebond;
            audi.PlayOneShot(soundRebond);
        }     
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

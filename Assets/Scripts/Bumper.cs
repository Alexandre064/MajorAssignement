using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public Rigidbody2D rd;
    public float speed;
    public float MaxX;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        if(x < 0.0){
            moveLeft();
        }
        if(x > 0.0){
            moveRight();
        }
        if(x == 0){
            Stop();
        }

        Vector2 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x,-MaxX,MaxX);
        transform.position = pos;
    }

    void moveLeft(){
        rd.velocity = new Vector2(-speed, 0);
    }
    void moveRight(){
        rd.velocity = new Vector2(speed, 0);
    }
    void Stop()
    {
        rd.velocity = Vector2.zero;
    }
}

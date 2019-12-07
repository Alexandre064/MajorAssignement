using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class brick : MonoBehaviour
{
    // Start is called before the first frame update
    public UiManager ui;
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
            Regex regex = new Regex(@"BrickQuizer \(\d\)");
            Match match = regex.Match(gameObject.name);
            if(match.Success){
                //Debug.Log(match.Value);
            }
            ui.IncrementScore();            
            Destroy(gameObject);
        }
    }
}

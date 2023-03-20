using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    public Birdcript birdcript;
    
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        birdcript = GameObject.FindGameObjectWithTag("Player").GetComponent<Birdcript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Won't add point if bird goes through pipe after it died
        if(collision.gameObject.layer == 8 && birdcript.birdIsAlive)
        {
            logic.addScore(1);
        }
        
    }

}

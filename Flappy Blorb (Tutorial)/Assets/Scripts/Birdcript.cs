using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdcript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float height = 6f;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public float maxHeight = 14;
    public float minHeight = -13;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive)
        {
            myRigidBody.velocity = Vector2.up * height;
        }
        
        if(transform.position.y > maxHeight || transform.position.y < minHeight)
        {
            logic.gameOver();
            birdIsAlive = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }

}

//File for controlling the right paddle
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movements : MonoBehaviour {
    private Rigidbody2D rig;
    public KeyCode up = KeyCode.UpArrow;
    public KeyCode down = KeyCode.DownArrow; //movement with the up and down arrows for the paddle

	// Use this for initialization
	void Start () {
        rig = GetComponent<Rigidbody2D>(); //The initial set up for the rigid body
	}
	
	// Update is called once per frame
	void Update () {
        var corners = transform.position;    //To know how far it can go up and down
        var paddleVelocity = rig.velocity;   //set the speed of the paddle depending on the if loops

        if (Input.GetKey(up))
        {
            paddleVelocity.y = 5.0f;         //Spped for paddle
        }
        else if (Input.GetKey(down))
        {
            paddleVelocity.y = -5.0f;        //Spped for paddle
        }
        else{
            paddleVelocity.y = 0;            //Spped for paddle
        }
        rig.velocity = paddleVelocity;


        if (corners.y > 2.25f)              //set the position so it does not go past bounds
        {
            corners.y = 2.25f;
        }
        else if (corners.y < -2.25f)
        {
            corners.y = -2.25f;
        }
        transform.position = corners;
    }
}

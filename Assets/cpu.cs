//File for the paddle that is ocntrolled by the computer
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cpu : MonoBehaviour {
    private Rigidbody2D rig;
    public Transform ballTransform;
    public Transform thisTransform;


    // Use this for initialization
    void Start () {
        ballTransform = GameObject.FindGameObjectWithTag("Ball").GetComponent<Transform>();
        thisTransform = this.gameObject.GetComponent<Transform>();
        rig = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        var corners = transform.position;
        var paddleVelocity = rig.velocity;
        if (ballTransform.position.y > thisTransform.position.y)
        {

            paddleVelocity.y = 2f;
        }
        if (ballTransform.position.y < thisTransform.position.y)
        {

            paddleVelocity.y = -2f;         //How fast the CPU paddle moves, 2 is a good difficulty 
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displays : MonoBehaviour {                                                         //Initialize the scores at 0
    public static int cpuScore = 0;
    public static int playerScore = 0;

    public GUISkin layout;

    GameObject Ball;

    // Use this for initialization
    void Start () {
        Ball = GameObject.FindGameObjectWithTag("Ball");
    }
    public static void pointScored(string wall)                                                  //Main function for keeping track of the scores
    {
        if (wall == "left")
        {
            playerScore++;
        }
        else
        {
            cpuScore++;
        }
    }

    void OnGUI()
    {
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + cpuScore);          //Position of the scores and added the font to the skin
        GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + playerScore);

        if (cpuScore == 5)                                                                      //Change the 5's if the game needs to be longer or shorter
        {
            GUI.Label(new Rect(Screen.width / 2-150 , 200, 2000, 1000), "Game Over, You lose");
            Ball.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
        }
        else if (playerScore == 5)
        {
            GUI.Label(new Rect(Screen.width / 2 - 160, 200, 2000, 1000), "Game Over, You Won!!!");
            Ball.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
        }
    }
}

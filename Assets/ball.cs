//File for starting the ball movements on score and on start of the game
using System.Collections; using System.Collections.Generic; using UnityEngine; using System; using Random = UnityEngine.Random;  public class ball : MonoBehaviour
{     private Rigidbody2D rig;      void moveBall()
    {         //This will be the function to move the ball
        float whosTurn = Random.Range(0, 2);
        Console.WriteLine("This is the player who is going next");         Console.WriteLine(whosTurn);         if (whosTurn < 1)                           //random generator determines if ball goes left or right         {             rig.AddForce(new Vector2(20, -20));     //ball goes right         }         else         {             rig.AddForce(new Vector2(-20, -20));    //ball goes left         }     }
    // Use this for initialization
    void Start()
    {         rig = GetComponent<Rigidbody2D>();
        Invoke("moveBall", 2);     }
     void spawn()                                //This starts the ball again after someone scoeres
    {         rig.velocity = Vector2.zero;         transform.position = Vector2.zero;
        Invoke("moveBall", 2);     }
    void ResetBall()
    {
        rig.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    } }
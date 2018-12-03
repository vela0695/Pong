using UnityEngine;
using System.Collections;

public class sides : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.name == "Ball")
        {
            string wallName = transform.name;                                                   //This will tell us which wall it hit to award the points
            displays.pointScored(wallName);
            hitInfo.gameObject.SendMessage("spawn", 3.0f, SendMessageOptions.RequireReceiver); //call the spawn function after someone has scored
        }
    }
}

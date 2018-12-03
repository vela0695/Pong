using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class scripts : MonoBehaviour {

	// Use this for initialization
	void Start () {
		                                    //Scripts to switch from menu screen and game screen
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void helpMenu(){
        SceneManager.LoadScene(1);
    }

    public void backToGame(){
        SceneManager.LoadScene(0);
    }
}

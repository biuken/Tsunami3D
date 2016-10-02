using UnityEngine;
using System.Collections;

public class visibilityX : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        gameObject.SetActive(Screen.fullScreen);
	
	}

    public void Exit()
    {
        Application.Quit();
    }
}

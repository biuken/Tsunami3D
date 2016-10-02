using UnityEngine;
using System.Collections;

public class TsunamiLogo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < -500)
        {
            transform.position = new Vector3(150, transform.position.y, transform.position.z);
        }
	    transform.position = new Vector3(transform.position.x - 0.3f, transform.position.y, transform.position.z);
    }
}

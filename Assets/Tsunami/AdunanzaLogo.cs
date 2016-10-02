using UnityEngine;
using System.Collections;

public class AdunanzaLogo : MonoBehaviour {

    public float _Angle;
    public float _Period;

    private float _Time;

    // Use this for initialization
    void Start () {
        _Angle = 18.9f;
        _Period = 3.5f;
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Rotate(Vector3.right * (Time.deltaTime*20));
        _Time = _Time + Time.deltaTime;
        float phase = Mathf.Sin(_Time / _Period)-90;
        transform.localRotation = Quaternion.Euler(new Vector3(phase * _Angle, 180, 0));
    }
}

using UnityEngine;
using System.Collections;

public class ViewManager : MonoBehaviour
{
	// Use this for initialization
	void Start () {
        Debug.Log("ViewManager::start");
	}

    [System.Diagnostics.Conditional("DEBUG"), System.Diagnostics.Conditional("UNITY_EDITOR")]
    void OnGUI()
    {
        GUI.Label(new Rect(20, 20, 100, 20), "mouse  x: " + Input.mousePosition.x.ToString());
        GUI.Label(new Rect(20, 40, 100, 20), "mouse  y: " + Input.mousePosition.y.ToString());

        GUI.Label(new Rect(20, 80, 100, 20), "width  : " + Screen.width.ToString());
        GUI.Label(new Rect(20, 100, 100, 20), "height : " + Screen.height.ToString());

        GUI.Label(new Rect(20, 140, 100, 20), "torrents : " + SessionManager.SM.torrent_list.Count);

    }

    // Update is called once per frame
    void Update ()
    {
        Vector3 mousePosition = Input.mousePosition;
        float sht = ((mousePosition.x / Screen.width) * 18) - 9;
        float svt = ((mousePosition.y / Screen.height) * 18) - 9;

        Camera.main.transform.position = new Vector3(sht, svt, -10);
    }
}

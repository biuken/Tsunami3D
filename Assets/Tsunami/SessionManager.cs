using UnityEngine;
using System.Collections.Generic;
using System.Runtime.InteropServices;
public class SessionManager : MonoBehaviour {

    public static SessionManager SM;
    [DllImport("tinyfiledialogs64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    public static extern System.IntPtr tinyfd_openFileDialog(string aTitle, string aDefaultPathAndFile, int aNumOfFilterPatterns, string aFilterPatterns, string aSingleFilterDescription, int aAllowMultipleSelects);

    public float download_rate;
    public int donwloaded_bytes;
    public List<TorrentRecord> torrent_list;

    // Use this for initialization
    void Start ()
    {
        SM.download_rate = 0;
        SM.donwloaded_bytes = 0;
        torrent_list = new List<TorrentRecord>();
        Debug.Log("SessionManager::started");
	}
	
	// Update is called once per frame
	void Update () {

	}

    void Awake()
    {
        if (SM != null)
            Destroy(SM);
        else
            SM = this;
        Debug.Log("SessionManager::awake");
        DontDestroyOnLoad(this);
    }

    public void addTorrent_onClick()
    {
        System.IntPtr fdiag = tinyfd_openFileDialog("choose torrent", "./", 0, "", "", 1);
        string path = Marshal.PtrToStringAnsi(fdiag);
        fdiag = System.IntPtr.Zero;
        var fileInfo = new System.IO.FileInfo(path);
        TorrentRecord tr = new TorrentRecord();
        tr._name = fileInfo.Name;
        tr._size = fileInfo.Length;
        tr._downloaded = 0;
        torrent_list.Add(tr);
        Debug.Log(path);
        
    }
}

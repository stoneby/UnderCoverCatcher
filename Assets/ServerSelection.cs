using System.Collections.Generic;
using UnityEngine;

public class ServerSelection : MonoBehaviour
{
    public List<string> ServerList;

    private readonly ListBox listBox = new ListBox();

    void OnGUI()
    {
        var centerRect = new CenterRect(200, 200);
        GUILayout.BeginArea(centerRect.Rect);

        GUI.Label(new Rect(0, 0, centerRect.Width, 25), ("Choose a server."));

        listBox.LoadList(ServerList);
        listBox.Draw(new Rect(0, 25, centerRect.Width, ServerList.Count * 25), 25, Color.grey, Color.red);

        if (GUI.Button(new Rect(50, 150, 100, 25), "Connect"))
        {
            Debug.Log("Connect to server ." + listBox.selectedEntry);
            Network.Connect("127.0.0.1", 5001);
            //Application.LoadLevel(ConstUtils.LevelClientWaiting);            
        }

        GUILayout.EndArea();
    }

    void Start()
    {
		Utils.NetWorkDebug();
    }
}

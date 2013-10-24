using UnityEngine;

public class ClientWaiting : MonoBehaviour
{
    public int ClientNum;

    void OnGUI()
    {
        var centerRect = new CenterRect(200, 200);
        GUILayout.BeginArea(centerRect.Rect);

        GUI.Label(new Rect(0, 0, centerRect.Width, 25), "Waiting for others join.");
        GUI.Label(new Rect(0, 25, centerRect.Width, 25), string.Format("Client number: {0}", ClientNum));

        if (GUI.Button(new Rect(50, 50, 100, 25), "Start"))
        {
            Application.LoadLevel(ConstUtils.LevelPhraseLookout);
        }

        GUILayout.EndArea();
    }

    void Start()
    {
        Utils.NetWorkDebug();
    }
}

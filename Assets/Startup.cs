using UnityEngine;

public class Startup : MonoBehaviour
{
    public int ConnectionNum;
    public int Port;

    void OnGUI()
    {
        var centerRect = new CenterRect(200, 200);
        GUILayout.BeginArea(centerRect.Rect);

        if (GUI.Button(new Rect(50, 0, 100, 25), "Create Server"))
        {
            Network.InitializeServer(ConnectionNum, Port, false);
            Application.LoadLevel(ConstUtils.LevelClientWaiting);
        }

        if (GUI.Button(new Rect(50, 50, 100, 25), "Connect"))
        {
            Application.LoadLevel(ConstUtils.LevelServerSelection);
        }

        GUILayout.EndArea();
    }
}

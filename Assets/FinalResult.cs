using UnityEngine;

public class FinalResult : MonoBehaviour
{
    public bool Result;

    void OnGUI()
    {
        var centerRect = new CenterRect(200, 200);
        GUILayout.BeginArea(centerRect.Rect);

        GUI.Label(new Rect(0, 0, centerRect.Width, 25), (Result ? "You Win." : "You Lose."));

        if (GUI.Button(new Rect(50, 150, 100, 25), "Return"))
        {
            Debug.Log("Return to main menu.");
            Application.LoadLevel(ConstUtils.LevelStartup);
        }

        GUILayout.EndArea();
    }
}

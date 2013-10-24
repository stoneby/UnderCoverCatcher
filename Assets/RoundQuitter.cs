using UnityEngine;

public class RoundQuitter : MonoBehaviour
{
    void OnGUI()
    {
        var centerRect = new CenterRect(200, 200);
        GUILayout.BeginArea(centerRect.Rect);

        GUI.Label(new Rect(0, 0, centerRect.Width, 25), string.Format("You quit."));

        if (GUI.Button(new Rect(50, 150, 100, 25), "Return"))
        {
            Debug.Log("Return to main menu.");
        }

        GUILayout.EndArea();
    }
}

using System.Collections.Generic;
using UnityEngine;

public class PhraseLookout : MonoBehaviour
{
    public string Phrase;
    public List<string> NameList;

    private ListBox listBox = new ListBox();

    void OnGUI()
    {
        var centerRect = new CenterRect(200, 200);
        GUILayout.BeginArea(centerRect.Rect);

        GUI.Label(new Rect(0, 0, centerRect.Width, 25), string.Format("Your phase: {0}.", Phrase));

        if (GUI.Button(new Rect(50, 75, 100, 25), "Go"))
        {
            Debug.Log("Go to next level. UnderCover judgement.");
            Application.LoadLevel(ConstUtils.LevelJudgement);
        }

        GUILayout.EndArea();
    }
}

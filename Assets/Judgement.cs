using System.Collections.Generic;
using UnityEngine;

public class Judgement : MonoBehaviour
{
    public int Index;
    public List<string> NameList;

    private ListBox listBox = new ListBox();

    private void OnGUI()
    {
        var centerRect = new CenterRect(200, 200);
        GUILayout.BeginArea(centerRect.Rect);

        GUI.Label(new Rect(0, 0, centerRect.Width, 25), string.Format("No. {0}", Index));

        listBox.LoadList(NameList);
        listBox.Draw(new Rect(0, 25, centerRect.Width, NameList.Count * 25), 25, Color.grey, Color.blue);

        if (GUI.Button(new Rect(50, 150, 100, 25), "It's him."))
        {
            Debug.Log("Choose person: " + listBox.selectedEntry);
        }

        GUILayout.EndArea();
    }
}

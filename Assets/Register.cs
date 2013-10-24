using UnityEngine;

public class Register : MonoBehaviour
{
    public string Username;
    public GUITexture Photo;

    void OnGUI()
    {
        if (GUILayout.Button("Test me!"))
        {
            Debug.Log(this);
        }

        var centerRect = new CenterRect(200, 200);
        GUILayout.BeginArea(centerRect.Rect);
        GUI.Label(new Rect(0, 0, 50, 25), "Name: ");
        Username = GUI.TextField(new Rect(50, 0, 100, 25), Username);
        GUI.Label(new Rect(0, 25, 50, 25), "Photo: ");
        if (GUI.Button(new Rect(100, 25, 50, 25), "..."))
        {
            // TODO: Take photo.
        }

        if (GUI.Button(new Rect(0, 50, 150, 25), "Register"))
        {
            
        }
        GUILayout.EndArea();
    }

    public override string ToString()
    {
        return string.Format("name: {0}, photo: {1}", Username, Photo);
    }
}

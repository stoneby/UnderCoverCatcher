using UnityEngine;

public class CenterRect
{
    public int Width { get; set; }
    public int Height { get; set; }

    public CenterRect(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public Rect Rect
    {
        get
        {
            return new Rect(Screen.width / 2 - Width / 2, Screen.height / 2 - Height / 2, Width, Height);
        }
    }
}

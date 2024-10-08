using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpGUI : MonoBehaviour
{

    public Texture2D buttonImage;
    public Vector2 position;
    public Vector2 size;
    private void OnGUI()
    {
        if (GUI.RepeatButton(new Rect(0, 0, 200, 200), "Left"))
        {
            print("left");
            position = position + Vector2.left;
        }

        if (GUI.RepeatButton(new Rect(1270, 0, 200, 200), "Right"))
        {
            print("right");
            position = position + Vector2.right;
        }

        if (GUI.RepeatButton(new Rect(1270, 550, 200, 200), "down"))
        {
            print("down");
            position = position - Vector2.down;
        }

        if (GUI.RepeatButton(new Rect(0, 550, 200, 200), "Up"))
        {
            print("up");
            position = position - Vector2.up;
        }

        GUI.Box(new Rect(position, size), buttonImage);
    }
}

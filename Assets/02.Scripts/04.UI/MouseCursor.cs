using UnityEngine;

public class MouseCursor : MonoBehaviour
{
    //public static MouseCursor instance;

    [SerializeField] private Texture2D cursorIcon;

    private void Start()
    {
        Cursor.SetCursor(cursorIcon, Vector2.zero, CursorMode.Auto);
    }

    private void Update()
    {
        if(Time.timeScale==0)
        {
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        }
        else
        {
            Cursor.SetCursor(cursorIcon, Vector2.zero, CursorMode.Auto);
        }

    }

}

## Controlling Aspect Ratio in Unity

Games made with Unity allow users to pick a screen resolution on startup through Unity's Display Resolution Dialog. While it's possible to disable this feature and force a game to use a particular resolution, it's generally not a good idea to deny users the ability to set the game's resolution to whatever they think is best. Such flexibility comes at a price, however, and one of the costs is the loss of control over the game window's aspect ratio.

```cs
// Use this for initialization
void Start () 
{
    // set the desired aspect ratio (the values in this example are
    // hard-coded for 16:9, but you could make them into public
    // variables instead so you can set them at design time)
    float targetaspect = 16.0f / 9.0f;

    // determine the game window's current aspect ratio
    float windowaspect = (float)Screen.width / (float)Screen.height;

    // current viewport height should be scaled by this amount
    float scaleheight = windowaspect / targetaspect;

    // obtain camera component so we can modify its viewport
    Camera camera = GetComponent<Camera>();

    // if scaled height is less than current height, add letterbox
    if (scaleheight < 1.0f)
    {  
        Rect rect = camera.rect;

        rect.width = 1.0f;
        rect.height = scaleheight;
        rect.x = 0;
        rect.y = (1.0f - scaleheight) / 2.0f;
        
        camera.rect = rect;
    }
    else // add pillarbox
    {
        float scalewidth = 1.0f / scaleheight;

        Rect rect = camera.rect;

        rect.width = scalewidth;
        rect.height = 1.0f;
        rect.x = (1.0f - scalewidth) / 2.0f;
        rect.y = 0;

        camera.rect = rect;
    }
}

```

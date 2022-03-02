/*
 * Evan Wieland
 * Project 1
 * Controls color changing
 */

using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public GameObject colorwheel;
    public Sprite red;
    public Sprite blue;
    public Sprite green;
    public Sprite yellow;

    Dictionary<string, Color> ColorsList = new Dictionary<string, Color>();

    // Initial color is green
    public static string _colorText;
    private static Color _color;

    public static Color color
    {
        get { return _color; }
    }

    public static string colorText
    {
        get { return _colorText; }
    }

    public static void reset()
    {
        _colorText = "GREEN";
        _color = Color.green;
    }

    void Start()
    {
        reset();

        ColorsList.Add("GREEN", Color.green);
        ColorsList.Add("YELLOW", Color.yellow);
        ColorsList.Add("RED", Color.red);
        ColorsList.Add("BLUE", Color.blue);
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _colorText = "GREEN";
            ChangeSprite(green);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _colorText = "YELLOW";
            ChangeSprite(yellow);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _colorText = "BLUE";
            ChangeSprite(blue);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _colorText = "RED";
            ChangeSprite(red);
        }

        _color = ColorsList[_colorText];
    }

    void ChangeSprite(Sprite newSprite)
    {
        if(spriteRenderer)
            spriteRenderer.sprite = newSprite;
    }
}

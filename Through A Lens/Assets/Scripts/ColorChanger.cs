using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ColorChanger : MonoBehaviour
{
    Dictionary<string, Color> ColorsList = new Dictionary<string, Color>();

    // Initial color is green
    private static string _colorText;
    private static Color _color;

    public static Color color
    {
        get { return _color; }
    }

    public static string colorText
    {
        get { return _colorText; }
    }

    public Text textbox;

    public static void reset()
    {
        _colorText = "GREEN";
        _color = Color.green;
    }

    void Start()
    {
        reset();
        textbox.GetComponent<Text>();
        textbox.text = _colorText;
        textbox.color = _color;

        ColorsList.Add("GREEN", Color.green);
        ColorsList.Add("YELLOW", Color.yellow);
        ColorsList.Add("RED", Color.red);
        ColorsList.Add("BLUE", Color.blue);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _colorText = "GREEN";
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            _colorText = "YELLOW";
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            _colorText = "BLUE";
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            _colorText = "RED";
        }

        _color = ColorsList[_colorText];

        textbox.text = _colorText;
        textbox.color = _color;
    }
}

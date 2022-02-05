using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    public static readonly Color green = Color.green;
    public static readonly Color yellow = Color.yellow;
    public static readonly Color red = Color.red;
    public static readonly Color blue = Color.blue;

    // Initial color is green
    private Color _color = green;

    public Text textbox;

    void Start()
    {
        textbox.GetComponent<Text>();
        textbox.text = _color.ToString();
        textbox.color = _color;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _color = green;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _color = yellow;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _color = red;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _color = blue;
        }

        textbox.text = _color.ToString();
        textbox.color = _color;
    }
}

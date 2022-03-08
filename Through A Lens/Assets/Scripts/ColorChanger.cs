/*
 * Evan Wieland
 * Project 1
 * Controls color changing
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    public SpriteRenderer playerSprite;
    public Sprite[] playerSpritesArray = new Sprite[4];
    public Image colorWheel;
    public Sprite[] wheelSpritesArray = new Sprite[4];
    private Animator animator;
    public RuntimeAnimatorController[] runtimeAnimatorControllers = new RuntimeAnimatorController[4];
    public static bool allowColorChange = true;

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

    void Awake () 
    {
        animator = this.GetComponent<Animator>();
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
        if(!allowColorChange) return;
           
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _colorText = "GREEN";
            animator.runtimeAnimatorController = runtimeAnimatorControllers[0];
            colorWheel.sprite = wheelSpritesArray[0];
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _colorText = "YELLOW";
            animator.runtimeAnimatorController = runtimeAnimatorControllers[1];
            colorWheel.sprite = wheelSpritesArray[1];
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _colorText = "RED";
            animator.runtimeAnimatorController = runtimeAnimatorControllers[2];
            colorWheel.sprite = wheelSpritesArray[2];
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _colorText = "BLUE";
            animator.runtimeAnimatorController = runtimeAnimatorControllers[3];
            colorWheel.sprite = wheelSpritesArray[3];
        }
        _color = ColorsList[_colorText];
    }
}

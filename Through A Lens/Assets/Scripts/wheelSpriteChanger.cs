using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wheelSpriteChanger : MonoBehaviour
{
    public Image img;
    public Sprite[] colorarray = new Sprite[4];

    // Update is called once per frame
    void Update()
    {
        if(ColorChanger.colorText == "GREEN")
        {
            img.sprite = colorarray[0]; 
        }
        else if (ColorChanger.colorText == "YELLOW")
        {
            img.sprite = colorarray[1];
        }
        else if (ColorChanger.colorText == "RED")
        {
            img.sprite = colorarray[2];
        }
        else if (ColorChanger.colorText == "BLUE")
        {
            img.sprite = colorarray[3];
        }
    }
}

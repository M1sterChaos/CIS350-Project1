/*
Luke Lesimple 
Project 1
Spawns platforms
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    //level length
    public int numPlats;

    //platform, money, finish line prefabs
    public GameObject Grey;
    public GameObject Money;
    public GameObject Finish;

    //array of 4 platform color prefabs
    public GameObject[] plattypes = new GameObject[4];

    //x and y of platforms
    public float xval = 0;
    public float yval = 0;

    //misc
    private float xvaldist;
    private int lastcolor = -1;
    private int moneycount = 0;

    private GameObject[] stuff;

    public static int level = 0;

    // Start is called before the first frame update
    void Start()
    {
        //spawn platform
        Instantiate(Grey, new Vector3(0, 0, 0), Quaternion.identity);
        levelGen(level);
    }

    public void levelGen(int level)
    {
        dataReset();
        if (level == 0)
        {
            numPlats = 10;
            standard();
        }
        else if (level == 1)
        {
            numPlats = 15;
            standard();
        }
        else if (level == 2)
        {
            numPlats = 10;
            speedrun();
        }
        
        //Finish platform
        Instantiate(Grey, new Vector3(xval + 8.0f, yval, 0.0f), Quaternion.identity);
        Instantiate(Finish, new Vector3(xval + 8.0f, yval + 1.0f), Quaternion.identity);
    }

    public void dataReset()
    {
        stuff = GameObject.FindGameObjectsWithTag("Floor");
        for (int i = 0; i < stuff.Length; i++)
        {
            Destroy(stuff[i]);
        }
        DestroyImmediate(GameObject.FindGameObjectWithTag("Finish"), true);
        xval = 0;
        yval = 0;
    }


    //returns platform gameobject of random color
    GameObject randColor()
    {
        int color;
        do
        {
            color = Random.Range(0, 4);
        }
        while (lastcolor == color);
        lastcolor = color;
        return plattypes[color];
    }

    //generates standard left-right level
    void standard()
    {
        xvaldist = 8.0f;

        for(int i = 1; i <= numPlats; i++)
        {
            xval = xval + xvaldist;
            yval = Random.Range(yval - 3.0f, yval + 3.0f);

            moneyGen(i);

            Instantiate(randColor(), new Vector3(xval, yval, 0.0f), Quaternion.identity);
        }
    }

    //generates left-right level with larger jumps
    void speedrun()
    {
        xvaldist = 18.0f;

        for(int i = 1; i <= numPlats; i++)
        {
            
            xval += xvaldist;
            yval = Random.Range(yval - 3.5f, yval + 3.5f);

            moneyGen(i);

            Instantiate(randColor(), new Vector3(xval, yval, 0.0f), Quaternion.identity);
        }

    }

    //Randomly places money
    void moneyGen(int iteration)
    {
        if (Random.Range(1, 12) <= 3 && moneycount < 3)
        {
            Instantiate(Money, new Vector3(xval, yval + 3.0f, 0.0f), Quaternion.identity);
            moneycount++;
        }
        else if ((moneycount < 1 && iteration == 4) || (moneycount < 2 && iteration == 8) || (moneycount < 3 && iteration == numPlats-1))
        {
            Instantiate(Money, new Vector3(xval, yval + 3.0f, 0.0f), Quaternion.identity);
            moneycount++;
        }
    }

}

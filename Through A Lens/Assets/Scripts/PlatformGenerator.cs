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
    public int numPlats = 10;

    public float[] platY;
    public float[] platX;



    //platform prefabs
    public GameObject Grey;
    public GameObject Red;
    public GameObject Yellow;
    public GameObject Green;
    public GameObject Blue;
    public GameObject Money;
    public GameObject Finish;

    // Start is called before the first frame update
    void Start()
    {
        // Creates array of x and y for platforms
        platY = new float[numPlats];
        platX = new float[numPlats];

        platY[0] = 0.0f;
        platX[0] = 8.0f;

        Instantiate(Grey, new Vector3(0, 0, 0), Quaternion.identity);

        float xval = 0;
        float yval = 0;
        int color;
        int lastcolor = -1;
        int moneycount = 0;
        



        for (int i = 1; i <= numPlats; i++)
        {
            xval = xval + 8.0f;
            yval = Random.Range(yval - 2.0f, yval + 2.0f);
            

            color = Random.Range(0, 4);
            while(lastcolor == color)
            {
                color = Random.Range(0, 4);
            }

            if(color == 1)
            {
                Instantiate(Red, new Vector3(xval, yval, 0.0f), Quaternion.identity);
            }
            else if (color == 2)
            {
                Instantiate(Green, new Vector3(xval, yval, 0.0f), Quaternion.identity);
            }
            else if (color == 3)
            {
                Instantiate(Yellow, new Vector3(xval, yval, 0.0f), Quaternion.identity);
            }
            else if (color == 0)
            {
                Instantiate(Blue, new Vector3(xval, yval, 0.0f), Quaternion.identity);
            }
            lastcolor = color;

            if (Random.Range(1, 12) <= 3 && moneycount < 3)
            {
                Instantiate(Money, new Vector3(xval, yval + 3.0f, 0.0f), Quaternion.identity);
                moneycount++;
            }
            else if ((moneycount < 1 && i == 4) || (moneycount < 2 && i == 8)) 
            {
                Instantiate(Money, new Vector3(xval, yval + 3.0f, 0.0f), Quaternion.identity);
                moneycount++;
            }

        }
        if(moneycount < 3)
        {
            Instantiate(Money, new Vector3(xval, yval + 3.0f, 0.0f), Quaternion.identity);
        }
        Instantiate(Grey, new Vector3(xval + 8.0f, yval, 0.0f), Quaternion.identity);
        Instantiate(Finish, new Vector3(xval + 8.0f, yval + 1.0f), Quaternion.identity);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

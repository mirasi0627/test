using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ibent : MonoBehaviour
{
    //制限時間
    public int time = 60;
    //延長する時間
    public int increasingTime = 1;
    public int timeLimit;

    // Start is called before the first frame update
    void Start()
    {
        timeLimit = time;
        int randomValue = Random.Range(1, 101);

        if (randomValue <= 20)
        {
            timeLimit = timeLimit + increasingTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeLimit -= timeLimit;

        if (time <= 0)
        {
            Debug.Log("Time up");
        }
    }
}
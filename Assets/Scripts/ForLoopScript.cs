using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class ForLoopScript : MonoBehaviour {

    // start for loop 
    public void ExecuteLoop()
    {

        int x = 0;

        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();

        for (int i = 0; i < 500; i++)
        {
            x += i;
        }

        stopWatch.Stop();
        UnityEngine.Debug.Log("Time taken: " + (stopWatch.Elapsed));
    }
}
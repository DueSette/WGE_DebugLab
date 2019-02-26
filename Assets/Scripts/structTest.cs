using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class structTest : MonoBehaviour {

    public class ClassInts
    {
        public int x;
    }

    public struct StructInts
    {
        public int x;
    }

    public ClassInts[] cInts;
    public StructInts[] sInts;
    private int size = 1000000;

	// Use this for initialization
	void Start ()
    {
        Stopwatch stp1 = new Stopwatch();
        Stopwatch stp2 = new Stopwatch();

        cInts = new ClassInts[size];
        sInts = new StructInts[size];

        stp1.Start();
        
        for (int i = 0; i < size; ++i)
        {
            cInts[i] = new ClassInts();
        }

        //for loop 1…
        for (int i = 0; i < size; i++)
        {
            RandomiseClass(cInts[i]);
        }

        stp1.Stop();
        print("stp1: " + stp1.Elapsed);

        stp2.Start();

        //for loop 2…
        for (int i = 0; i < size; i++)
        {
            RandomiseStruct(ref sInts[i]);
        }
        stp2.Stop();
        print("stp2: " + stp2.Elapsed);

    }

    void RandomiseStruct(ref StructInts s)
    {
        s.x = Random.Range(0, 100);
    }

    void RandomiseClass(ClassInts c)
    {
        c.x = Random.Range(0, 100);
    }
}

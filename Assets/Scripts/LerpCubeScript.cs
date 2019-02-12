using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class LerpCubeScript : MonoBehaviour {

    public GameObject _cube;
    public Vector3 _leftPosition;
    public Vector3 _rightPosition;

    public void StartLerp()
    {
        _cube.transform.position = _leftPosition;
        StartCoroutine(LerpCube());
    }

    IEnumerator LerpCube()
    {
        Stopwatch stp = new Stopwatch();
        stp.Start();
        float t = 0;

        while (t < 1)
        {

            t += Time.deltaTime;
            //UnityEngine.Debug.Log(t);

            _cube.transform.position = MyLerp(SmoothStart(_leftPosition, _rightPosition, t), SmoothStop(_leftPosition, _rightPosition, t), t);
            if (t >=1)
            {
                _cube.transform.position = _rightPosition;
            }
            yield return null;
        }
        stp.Stop();
        //UnityEngine.Debug.Log("coroutine time taken: " + stp.Elapsed);
    }

    public Vector3 MyLerp(Vector3 a, Vector3 b, float t)
    {
        
        return a + (b - a) * t;
    }

    public Vector3 SmoothStart(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * t * t;
    }

    public Vector3 SmoothStop(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * (1 - (1 - t) * (1 - t));
    }


    public void PrintDebugString()
    {
        UnityEngine.Debug.Log(this.ToString());
    }

    public override string ToString()
    {
        string s;
        s = (_cube ? "Cube positon = " + _cube.transform.position: "Cube not instantiated ") + "\n" + "Left Position = " + _leftPosition + "\n" + "Right Position = " + _rightPosition;
        return s;
    }


}

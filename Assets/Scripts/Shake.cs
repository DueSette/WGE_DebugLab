using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour {

    public float amount;
    public float speed;

    Vector3 currPos;
    float xOffs;
    float yOffs;
    float seed;

	// Use this for initialization
	void Start () {
        seed = Random.Range(0, 100000);
        currPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = currPos;
        currPos = transform.position;
        ShakeCam();
	}

    private void ShakeCam()
    {
        xOffs = Mathf.PerlinNoise(seed + Time.time * speed, 0) * 2 - 1;
        yOffs = Mathf.PerlinNoise(0, seed + Time.time * speed) * 2 - 1;
        transform.position = transform.position + new Vector3(xOffs * amount, yOffs * amount, 0);

    }
}

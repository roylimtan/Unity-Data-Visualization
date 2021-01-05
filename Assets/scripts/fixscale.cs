using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class fixscale : MonoBehaviour
{
    public float time;
    public float x;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(0, 0, 0);
        Invoke("scale", time);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void scale()
    {
        this.transform.localScale = new Vector3(x, x, x);
    }
}

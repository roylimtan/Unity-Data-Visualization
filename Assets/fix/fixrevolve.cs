using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixrevolve : MonoBehaviour
{
    public GameObject bts;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        OrbitAround();
    }

    void OrbitAround()
    {
        transform.RotateAround(bts.transform.position, Vector3.down, speed * Time.deltaTime);
    }
}

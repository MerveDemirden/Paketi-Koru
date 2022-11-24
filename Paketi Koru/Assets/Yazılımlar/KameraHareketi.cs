using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraHareketi : MonoBehaviour
{
    public float kameraHiz;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(kameraHiz * Time.deltaTime, 0, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkaplanDongusu : MonoBehaviour
{
    public float arkaplanHiz;
    public Renderer arkaplanRenderer;

    // Update is called once per frame
    void Update()
    {
        arkaplanRenderer.material.mainTextureOffset += new Vector2(arkaplanHiz * Time.deltaTime, 0f);
    }
}

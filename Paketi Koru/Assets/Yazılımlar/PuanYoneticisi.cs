using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuanYoneticisi : MonoBehaviour
{
    public Text puanText;
    private float puan;

    // Update is called once per frame
    void Update()
    {
       if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            puan += 1 * Time.deltaTime;
            puanText.text = ((int)puan).ToString();
        } 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyunBitti : MonoBehaviour
{
    public GameObject oyunBittiPaneli;

    // Update is called once per frame
    void Update()
    {
       if(GameObject.FindGameObjectWithTag("Player") == null)
        {
            oyunBittiPaneli.SetActive(true);
        } 
    }

    public void Yeniden()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerHiz;
    private Rigidbody2D rb;
    private Vector2 playerYon;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float yonY = Input.GetAxisRaw("Vertical");
        playerYon = new Vector2(0, yonY).normalized;

    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerYon.y * playerHiz);
    }

}

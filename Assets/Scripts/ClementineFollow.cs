using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClementineFollow : MonoBehaviour
{
    bool startfollow = false;
    GameObject player;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (startfollow)
        {
            // rb.position = 
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "player")
        {
            startfollow = true;
        }
    }
}

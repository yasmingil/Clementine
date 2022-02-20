using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 0.1f;
    [SerializeField] private float jumpSpeed = 0.1f;

    private Vector2 playerInput = new Vector2();
    private Rigidbody2D rb;
    private Animator anim;
    
    private enum PlayerState {IDLE, WALK, RUN, JUMP};
    private PlayerState currentState = PlayerState.IDLE;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        currentState = PlayerState.IDLE;
        float inputX = Input.GetAxis("Horizontal");
        playerInput.x = inputX;

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + playerInput * speed);
        anim.SetBool("walk", playerInput.x != 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // jump
            rb.MovePosition(rb.position + new Vector2(0, 1* jumpSpeed));
            

        }
    }
}

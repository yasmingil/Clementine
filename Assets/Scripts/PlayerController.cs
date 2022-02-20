using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float jumpSpeed = 1f;

    private Vector3 playerInput = new Vector3();
    private Rigidbody rb;
    
    private enum PlayerState {IDLE, WALK, RUN, JUMP};
    private PlayerState currentState = PlayerState.IDLE;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        currentState = PlayerState.IDLE;
        float inputX = Input.GetAxis("Horizontal");
        playerInput.x = inputX;
        playerInput.y = 0;
        playerInput.z = 0;
        if(playerInput.x != 0)
        {
            currentState = PlayerState.WALK;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentState = PlayerState.JUMP;
        }

        if (currentState == PlayerState.WALK)
        { 
            if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
            {
                currentState = PlayerState.RUN;
            }
            
        }

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + playerInput * speed);
        if (currentState.Equals(PlayerState.JUMP))
        {
            // jump
            rb.MovePosition(rb.position + new Vector3(0, 10, 0) * jumpSpeed);
            //rb.MovePosition(rb.position + new Vector3(0, -10, 0) * jumpSpeed);

        }
    }
}

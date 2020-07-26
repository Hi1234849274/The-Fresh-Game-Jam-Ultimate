using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour {

    Rigidbody2D rb;

    public float moveSpeed = 10f;
    public float jumpForce = 3f;
    public Transform groundCheck;
    public float checkRadius = 0.3f;
    public LayerMask whatIsGround;
  
    public float isGroundedRemember = 0.2f;
    bool isGrounded = false;
    float inputvar;


    void Start() {
        rb = GetComponent<Rigidbody2D>();        
    }
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) {
            Jump();
        }

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        
        //  Coyote Jumping
        if (isGrounded)
            isGroundedRemember = 0.2f;
        else
            isGroundedRemember -= Time.deltaTime;

        
        inputvar = Input.GetAxisRaw("Horizontal");
    }
    void FixedUpdate() {
        Vector2 movement = new Vector2(inputvar * moveSpeed, rb.velocity.y);

        rb.velocity = movement;
    }
    void Jump() {
        if (isGrounded) {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
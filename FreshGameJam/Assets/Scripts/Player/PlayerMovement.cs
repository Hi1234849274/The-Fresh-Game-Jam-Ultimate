using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour {

    Rigidbody2D rb;

    public float moveSpeed = 10f;
    public float jumpForce = 3f;
    public float accelerationTime = 1f;
    float inputvar;


    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update() {
        inputvar = Input.GetAxis("Horizontal");
    }
    void FixedUpdate() {
        Vector2 movement = new Vector2(inputvar * moveSpeed, 0);

        rb.velocity = movement;
    }
}
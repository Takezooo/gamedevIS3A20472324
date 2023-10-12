using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5f;
    public float jumpForce = 10f;
    private Rigidbody2D rb;
    private bool canJump = true;
    //private bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        Vector2 pos = transform.position;
        pos.x += h * speed * Time.deltaTime;

        //isGrounded = IsGrounded();

        // Add your jump input detection here
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            Jump();
        }

        transform.position = pos;
    }

    //Collision detector
    private void OnCollisionEnter2D(Collision2D col)
    {

        Debug.Log("Collided");
        canJump = true;

    }
    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
        canJump = false; // Disable jumping until the character lands
    }
    /*
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = true;
        }
    }
    */
    /*
    bool IsGrounded()
    {
        // Cast a ray downwards to check for ground collision with the "Ground" layer
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.1f, LayerMask.GetMask("Ground"));

        if (hit.collider != null)
        {
            Debug.Log("Grounded");
        }
        else
        {
            Debug.Log("Not Grounded");
        }

        return hit.collider != null;
    }
    */



}


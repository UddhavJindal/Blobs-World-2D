using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveF = 10f;
    public float jumpF = 11f;
    public AudioClip jumpClip;
    private float moveX;
    private float moveY;
    private Rigidbody2D myBody;
    private SpriteRenderer sr;
    private Animator anim;
    private string WalkAnim = "Walk";
    private bool isGrounded = true;
    private string GroundTag = "Platform";

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        AnimatePlayer();
        PlayerJump();
    }

    void PlayerMove()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(moveX, 0f, 0f) * Time.deltaTime * moveF;
    }

    void AnimatePlayer()
    {
        if(moveX > 0) //right
        {
            anim.SetBool(WalkAnim, true);
            sr.flipX = false;
        }
        else if(moveX < 0) //left
        {
            anim.SetBool(WalkAnim, true);
            sr.flipX = true;
        }
        else
        {
            anim.SetBool(WalkAnim, false);
        }
    }

    void PlayerJump()
    {
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            isGrounded = false;
            myBody.AddForce(new Vector2(0f, jumpF), ForceMode2D.Impulse);

            GetComponent<AudioSource>().clip = jumpClip;
            GetComponent<AudioSource>().Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag(GroundTag))
        {
            isGrounded = true;
        }
    }
}

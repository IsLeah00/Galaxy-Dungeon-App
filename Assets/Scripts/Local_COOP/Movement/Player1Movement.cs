using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 movement;
    public Animator animator;
    public Rigidbody2D rb;

    public float slideTime = 0f;
    public float MaxslideTime = 0.3f;
    private bool sliding = false;


    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetFloat("speed", movement.sqrMagnitude);
    }

    private void Update()
    {
        Movement();
        Run();
        Slide();
        Attack();
    }

    public void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            animator.SetTrigger("Attack");
        }
    }

    private void Slide()
    {
        if (Input.GetKeyDown(KeyCode.C) && !sliding)
        {
            slideTime = 0f;
            animator.SetBool("IsSlide", true);
            sliding = true;

        }

        if (sliding)
        {
            slideTime += Time.deltaTime;

            if (slideTime > MaxslideTime)
            {
                sliding = false;
                animator.SetBool("IsSlide", false);
            }
        }
    }

    private void Run()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("IsRun", true);
            speed = 7f;
        }
        else
        {
            animator.SetBool("IsRun", false);
            speed = 5f;
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    private void Movement()
    {
        animator.SetFloat("speed", 5);
        if (Input.GetKey("w"))
        {
            movement.y = 1;
        }
        if (Input.GetKey("s"))
        {
            movement.y = -1;
        }
        if (Input.GetKey("a"))
        {
            movement.x = -1;
        }
        if (Input.GetKey("d"))
        {
            movement.x = 1;
        }
        if (!Input.GetKey("w") && !Input.GetKey("s"))
        {
            movement.y = 0;
        }
        if (!Input.GetKey("a") && !Input.GetKey("d"))
        {
            movement.x = 0;
        }
        if (!Input.GetKey("a") && !Input.GetKey("d") && !Input.GetKey("w") && !Input.GetKey("s"))
        {
            animator.SetFloat("speed", 0);
        }
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
    }

}

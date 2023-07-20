using UnityEngine;

public class Player2Movement : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.RightControl) && !sliding)
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
        if (Input.GetKey(KeyCode.RightShift))
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
        if (Input.GetKey(KeyCode.UpArrow))
        {
            movement.y = 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            movement.y = -1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movement.x = -1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movement.x = 1;
        }
        if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow))
        {
            movement.y = 0;
        }
        if (!Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            movement.x = 0;
        }
        if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetFloat("speed", 0);
        }
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
    }
}
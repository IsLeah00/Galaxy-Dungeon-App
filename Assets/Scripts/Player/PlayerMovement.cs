using UnityEngine;

public class PlayerMovement : MonoBehaviour
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
    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("speed", movement.sqrMagnitude);

        Run();
        Slide();
        Attack();
    }

    public void Attack()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {

            animator.SetTrigger("Attack");
        }
    }

    private void Slide()
    {
        if(Input.GetKeyDown(KeyCode.C) && !sliding)
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

}

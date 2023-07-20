using System.Collections;
using UnityEngine;

public class Dash : MonoBehaviour
{
    private float horizontal;
    public float speed = 5f;
    public GameObject player;

    private bool canDash = true;
    private bool isDashing;
    private float dashingPower = 15f;
    private float dashingTime = 0.2f;
    private float dashingCooldown = 1f;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private TrailRenderer tr;

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (isDashing)
        {
            return;
        }
        else
        {
            player.GetComponent<Health>().enabled = true;
            player.GetComponent<PlayerMovement>().enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Y) && canDash)
        {
            StartCoroutine(DashLeft());
        }
        if (Input.GetKeyDown(KeyCode.X) && canDash)
        {
            StartCoroutine(DashRight());
        }
    }

    private IEnumerator DashLeft()
    {
        canDash = false;
        isDashing = true;
        player.GetComponent<Health>().enabled = false;
        player.GetComponent<PlayerMovement>().enabled = false;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f;

        rb.velocity = new Vector2(-transform.localScale.x * dashingPower, 0f);

        speed = 4f;
        tr.emitting = true;

        yield return new WaitForSeconds(dashingTime);

        tr.emitting = false;
        rb.gravityScale = originalGravity;
        isDashing = false;
        yield return new WaitForSeconds(dashingCooldown);
        canDash = true;
    }

    private IEnumerator DashRight()
    {
        canDash = false;
        isDashing = true;
        player.GetComponent<Health>().enabled = false;
        player.GetComponent<PlayerMovement>().enabled = false;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f;

        rb.velocity = new Vector2(transform.localScale.x * dashingPower, 0f);

        speed = 4f;
        tr.emitting = true;

        yield return new WaitForSeconds(dashingTime);

        tr.emitting = false;
        rb.gravityScale = originalGravity;
        isDashing = false;
        yield return new WaitForSeconds(dashingCooldown);
        canDash = true;
    }
}

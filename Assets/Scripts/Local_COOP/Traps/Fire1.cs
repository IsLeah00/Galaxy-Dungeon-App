using System.Collections;
using UnityEngine;

public class Fire1 : MonoBehaviour
{
    private bool active;
    private bool trigger;
    [SerializeField] private float damage;

    [SerializeField] private float Delay;
    [SerializeField] private float Time;
    private Animator anim;
    private SpriteRenderer sprite;


    private void Awake()
    {
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player1")
        {
            if (!trigger) { StartCoroutine(FireFunc()); }


            if (active) { collision.GetComponent<Health1>().TakeDamage(damage); }

        }
    }


    private IEnumerator FireFunc()
    {

        trigger = true;
        sprite.color = Color.red;
        yield return new WaitForSeconds(Delay);
        sprite.color = Color.white;
        active = true;
        anim.SetBool("Up", true);

        yield return new WaitForSeconds(Time);
        active = false;
        trigger = false;
        anim.SetBool("Up", false);

    }
}

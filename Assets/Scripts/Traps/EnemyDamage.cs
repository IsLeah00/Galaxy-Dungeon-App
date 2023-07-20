using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] protected float Edamage;

    AudioSource audioSource;
    public AudioClip hitSound;
    public Animator anim;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Health>().TakeDamage(Edamage);
            audioSource.PlayOneShot(hitSound);
            anim.SetBool("attack", true);
        }
    }
}

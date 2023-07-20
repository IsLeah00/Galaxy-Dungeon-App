using UnityEngine;

public class EnemyDamage1 : MonoBehaviour
{
    [SerializeField] protected float Edamage;

    AudioSource audioSource;
    public AudioClip hitSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }



    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player1")
        {
            collision.GetComponent<Health1>().TakeDamage(Edamage);
            audioSource.PlayOneShot(hitSound);
        }
    }
}

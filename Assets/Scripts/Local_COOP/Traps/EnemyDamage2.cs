using UnityEngine;

public class EnemyDamage2 : MonoBehaviour
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
        if (collision.tag == "Player2")
        {
            collision.GetComponent<Health2>().TakeDamage(Edamage);
            audioSource.PlayOneShot(hitSound);
        }
    }
}

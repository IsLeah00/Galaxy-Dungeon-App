using UnityEngine;

public class HealthSound2 : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip collectHealthSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.CompareTag("Player2"))
        {
            audioSource.PlayOneShot(collectHealthSound);
            Destroy(gameObject, 3);
        }
    }
}

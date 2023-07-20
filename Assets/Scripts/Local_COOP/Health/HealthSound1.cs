using UnityEngine;

public class HealthSound1 : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip collectHealthSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.CompareTag("Player1"))
        {
            audioSource.PlayOneShot(collectHealthSound);
            Destroy(gameObject, 3);
        }
    }
}

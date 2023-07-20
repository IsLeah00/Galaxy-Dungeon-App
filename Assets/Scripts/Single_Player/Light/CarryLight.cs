using UnityEngine;

public class CarryLight : MonoBehaviour
{

    public Transform carryLocation;
    public Transform currentItem;
    public int timer = 10;

    AudioSource audioSource;
    public AudioClip collectLightSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.CompareTag("Player"))
        {
            audioSource.PlayOneShot(collectLightSound);

            currentItem = currentItem.transform;

            currentItem.position = carryLocation.position;

            currentItem.parent = carryLocation;

            Destroy(gameObject, timer);
        }
    }
}

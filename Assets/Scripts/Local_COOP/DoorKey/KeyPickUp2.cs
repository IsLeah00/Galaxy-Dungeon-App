using UnityEngine;

public class KeyPickUp2 : MonoBehaviour
{
    public Transform carryLocation;
    public Transform currentItem;
    AudioSource audioSource;
    public AudioClip collectKeySound;
    public GameObject door;
    public GameObject UnlockedUI;
    public GameObject KeyUI;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.CompareTag("Player2"))
        {
            KeyPick();

            currentItem = currentItem.transform;
            currentItem.position = carryLocation.position;
            currentItem.parent = carryLocation;
        }

        if (Col.CompareTag("Door"))
        {
            KeyDrop();
            Unlocked();
            Destroy(gameObject);
        }
    }

    private void Unlocked()
    {
        UnlockedUI.SetActive(true);
    }

    private void KeyDrop()
    {
        KeyUI.SetActive(false);
    }

    private void KeyPick()
    {
        KeyUI.SetActive(true);
    }
}

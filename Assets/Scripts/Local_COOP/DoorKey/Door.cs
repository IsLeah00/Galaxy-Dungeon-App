using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door;

    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.CompareTag("Key"))
            Destroy(door);
    }
}
